using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Proekt_ClipboardManager
{
    
    public partial class Form1 : Form
    {
        public List<Object> allitems = new List<Object>();      // declare and initialize list of "Object", each item is something copied in clipboard but stored as "Object"... weill need casting for later use
        public int noOfItems;                                   // variable to store maximum number of itemst to be stored
        int width;                                              // width of the screen, used to determinate proper position of the form
        int height;                                             // height of the screen, used to determinate proper position of the form
        //golemina na listata
        //Here start initialization of fields neceserry for Clipboard Listener
        // <summary>
        // Places the given window in the system-maintained clipboard format listener list.
        // </summary>
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AddClipboardFormatListener(IntPtr hwnd);

        // <summary>
        // Removes the given window from the system-maintained clipboard format listener list.
        // </summary>
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool RemoveClipboardFormatListener(IntPtr hwnd);

        // <summary>
        // Sent when the contents of the clipboard have changed.
        // </summary
        private const int WM_CLIPBOARDUPDATE = 0x031D;
        //Here ends initialization of fields neceserry for Clipboard Listener

        public Form1()
        {   
            InitializeComponent();
            AddClipboardFormatListener(this.Handle);                    // ClipBoard Listener
            
            // add some code to deal with initialization of "List<Object> allitemes"
            //
            //
            // code for dealing with initialization of "List<Object> allitemes" ends here
            noOfItems = (int)nudStoredItems.Value;              // intilize number of items acorting to value in form numeric updown
            SetPosition();                                    // call methot to initialize width and height values representing screen size
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)                // method to close form when clicked "Close" button from context menu
        {
            // remove from listener then close form
            //Form1_FormClosing.()
            this.Close();
        }

        private void stripMenuReadClipboard_Click(object sender, EventArgs e)                // probably old code... should be removed
        {
        }

        private void stripMenuPaste_Click(object sender, EventArgs e)                    // old code... used onlky for debuging 
        {
            IDataObject idata = Clipboard.GetDataObject();
            //textBox2.Text = (String)idata.GetData(DataFormats.Text);
            //if (Clipboard.ContainsAudio())
            //    textBox2.Text = (string)Clipboard.GetData(DataFormats.WaveAudio);
            //str = idata.GetFormats();
        }


        //Setira item na Clipboard
        private void btnSetItems_Click(object sender, EventArgs e)                                   // old code... used for debuging
        {
            if (lbItems.SelectedIndex != -1)
            {
                int tmp = lbItems.SelectedIndex;
                //Clipboard.SetFileDropList(list[tmp]);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)                                        // method to hide icon from task bar
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void notifyTryIcon_MouseDoubleClick(object sender, MouseEventArgs e)                 // restore hiden form (hiden = palced in system try)
        {
            Show();
            WindowState = FormWindowState.Normal;
            this.SetPosition();
        }

        // old code, used only for debuging
        private void btnGet_Click(object sender, EventArgs e) //Gi zima site item - i / stringovi kopirani do sega
        {
            /*
            lbItems.Items.Clear();//go prebrisuva list box - ot da ne se dupliraat kopiranite item - i na get
            lbStrngs.Items.Clear();// -||-
            string[] s = new string[list.Count];
            string ch;
            string tmp;
            int index;
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list[i].CopyTo(s, 0);//go kopira vo s(string)
                    ch = s[0].ToString();//go smestuva vo string (nez zosto go staviv ova tocno)
                    index = ch.LastIndexOf("\\");//go zima indexot na posednoto "/" pa nataka
                    tmp = ch.Substring(index);//go pravi kako substring
                    lbItems.Items.Add(tmp);//go dodava vo listbox

                }
                for (int i = 0; i < copiedText.Count; i++)
                {
                    lbStrngs.Items.Add(copiedText[i]);//dodava samo stringovi vo listbox
                }
            }
                //exception - ov e zatoa sto paga ako kopiras poveke item - i
            catch (Exception ex)
            {
                MessageBox.Show("You have copied two items at once", "Warning", MessageBoxButtons.OK);
                // da definirame kade pagja programata spored parametrite
                // dali element e null ili nesto treto...
                // koga ke znaeme vo kakva sostojba e sekoja promeliva bi mozele
                // da kreirame metod koj ke dodava dva elementi namsto eden
                // vo momentov na edno pole vo "list" imame dva elementi od clipboard (pretpostavuvam)
                // najverojatno toa e problemot
            }
             */
            lbItems.Items.Clear();
            lbStrngs.Items.Clear();
            /*
             for (int i = 3; i < contextMenuStrip1.Items.Count; i++)  // clear context menu items
             {
                 contextMenuStrip1.Items.RemoveAt(i);
             }
             */
            for (int i = 0; i < allitems.Count(); i++)
            {
                //if(allitems[i].GetType == StringCollection)
                // >> lbStrngs.Items.Add(allitems[i]); >>
                if (allitems[i] is StringCollection)
                {
                    StringCollection sc = allitems[i] as StringCollection;
                    string s = sc[0].ToString();
                    int index = s.LastIndexOf("\\");//go zima indexot na posednoto "/" pa nataka
                    string name = s.Substring(index + 1);//go pravi kako substring

                    lbItems.Items.Add(name);
                    // contextMenuStrip1.Items.Add(name);

                    // **** pomogni mi tuka da go zemam strinot od lokacijata na elementot
                }
                else
                {
                    string name = allitems[i].ToString();
                    lbStrngs.Items.Add(name);
                    // contextMenuStrip1.Items.Add(name);
                }
            }
        }

        //gi brise dvete listiboxo - vi
        private void btnReset_Click(object sender, EventArgs e)     // old code... used only for debuging
        {
            lbItems.Items.Clear();
            lbStrngs.Items.Clear();
        }

        //Pocnuva logikata na clipboard listener
        protected override void WndProc(ref Message m)               // ClipBoard listener start here
                                                                      // method to catch clipboard changes
        {
            base.WndProc(ref m);

            if (m.Msg == WM_CLIPBOARDUPDATE)
            {
                if (Clipboard.ContainsFileDropList() && checkBoxItems.Checked)
                {
                    StringCollection item;
                    item = Clipboard.GetFileDropList();
                    if (item.Count == 1)
                    {
                        addToContextMenu(item);                     // add to context menu as last item
                                                                     // add more code to produce specific behaviour for adding files (documents)
                    }
                }
                else                                                   // if this else is reached then current clipboard item must be string
                {
                    if (Clipboard.ContainsText() && checkBoxText.Checked)                   // add one more check to prevent unexpected behaviour
                    {
                        string name = Clipboard.GetText();
                        addToContextMenu(name);                     // add current item in cotext menu
                                                                     // add more code here to produce specific behaviour for adding strings in clipboard, adding in context menu and deleteing duplicates
                    }
                }
            }
        }

        private void addToContextMenu(string name)  // method to add string in context menu
        {   
            //<generate more specific behaviour>
            // if(checkbox_delete_duplicates)....
            //
            // else...
            // <more specifici behaviour ends here>
            for (int i = 0; i < allitems.Count; i++)                        // by default we delete duplicates
            {
                int duplikat = ((String.CompareOrdinal(allitems[i].ToString(), name)));
                if (duplikat == 0)
                {
                    allitems.RemoveAt(i);
                }
            } 
                                                          // if there were any duplicates now they are gone
           
            if (allitems.Count > noOfItems)             // if we have maxiumim number of elements, delete odest one and add new one
            {
                for (int i = 0; i < allitems.Count - noOfItems+1; i++)
                allitems.RemoveAt(0);
                allitems.Add(name);
            }
            else
                allitems.Add(name);                                         // add provided string "name" to list of clipboard items

            sortAllItems();                                             // call method that will eventualy sort items
            
            generateContextMenu();                                      // call method to regenerate new context menu containing new item
        }

        private void sortAllItems()
        {
            if (rbSortByCategory.Checked == true)
            {
                if (rbSortTextFirst.Checked == true)
                {
                    SortAllItemsTextFirst();
                }
                else if (rbSortFilesAndFoldersFirst.Checked == true)
                {
                    SortAllItemsFilesAndFoldersFirst();
                }
            }
        }

        private void SortAllItemsFilesAndFoldersFirst() // *******************
        {
            List<object> newlist = new List<object>();      // generate empty list
            for (int i = 0; i < allitems.Count; i++)
            {
                if (allitems[i] is StringCollection)
                {
                    newlist.Add(allitems[i]);
                }
            }       // all files and folders are added

            for (int i = 0; i < allitems.Count; i++)        // now add text
            {
                if (!(allitems[i] is StringCollection))
                {
                    newlist.Add(allitems[i]);
                }
            }       // text has been added

            allitems = newlist;     // asign new (temporary) list to old one
        }

        private void SortAllItemsTextFirst() //******************
        {
            List<object> newlist = new List<object>();      // generate empty list
            for (int i = 0; i < allitems.Count; i++)
            {
                if (!(allitems[i] is StringCollection))    // add text to the list
                {
                    newlist.Add(allitems[i]);
                }
            }       // all text items has been added

            for (int i = 0; i < allitems.Count; i++)        // now add Files and Folders
            {
                if (allitems[i] is StringCollection)
                {
                    newlist.Add(allitems[i]);
                }
            }       // Files and Folders has been added

            allitems = newlist;     // asign new (temporary) list to old one
        }

        private void generateContextMenu()                                                      // method to generate menu
        {
            lbStrngs.Items.Clear();                                                                 // old code... used only for debuging
            lbItems.Items.Clear();                                                                  // old code... used only for debuging

            for (int i = 3; i < contextMenuStrip1.Items.Count; )                                  // first remove all items      ** notice, variable "i" is not incrementing **
                                                                                                  // .Counts return smaller integer in every next iteration
            {
                contextMenuStrip1.Items.RemoveAt(i);
            }                                                                                       // all items deleteted

            for (int i = 0; i < allitems.Count; i++)
            {
                if (allitems[i] is StringCollection)
                {
                    StringCollection sc = allitems[i] as StringCollection;
                    if (sc.Count > 1)
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int j = 0; j < sc.Count; j++)
                        {
                            string temp = sc[j].ToString();
                            int index = temp.LastIndexOf("\\");
                            string name = temp.Substring(index + 1);
                            sb.Append(name);
                            sb.Append(" || ");
                        }
                        lbItems.Items.Add(sb.ToString());
                        contextMenuStrip1.Items.Add(sb.ToString());
                    }
                    else
                    {
                        string s = sc[0].ToString();
                        int index = s.LastIndexOf("\\");//go zima indexot na posednoto "/" pa nataka
                        string name = s.Substring(index + 1);//go pravi kako substring
                        lbItems.Items.Add(name);
                        contextMenuStrip1.Items.Add(name);
                    }
                }

                else
                {
                    string name = allitems[i].ToString();
                    lbStrngs.Items.Add(name);
                    contextMenuStrip1.Items.Add(name);
                }
            }
        }

        private void addToContextMenu(StringCollection item)        // method to add StringColection to "[]allitems" and to "context_menu"
        {
            // by default we remove duplicates
            // write more code to get more specific begavior
            //
            //

            for (int i = 0; i < allitems.Count; i++)            // let's check for existing files equal to current one that should be added
            {
                if (allitems[i] is StringCollection)            // if i'th item in []allitmes is not of type StringColection then it can not be duplicate
                {
                    bool duplikat = false;                      // lets asume that there are no duplicates       
                    myStringColection mscItem = new myStringColection(item);        // myStringColection provides overrided CompareTo() method
                                                                                    // default compare to can not be used becouse of invalid casting
                                                                                    // parrent (Object) can not be casted to child (StringColection)
                                                                                    // solution is:
                                                                                    // "new class that accept argument of type "StringColection"
                                                                                    // and implementing it's own "Equals()" method"
                    duplikat = mscItem.Equals(allitems[i]);
                    if (duplikat)
                    {
                        allitems.RemoveAt(i);                                       // remove i'th items if it is equal to one that needs to be added
                    }
                }
            }                                                                       // if there are duplicates now they are gone

            if (allitems.Count > noOfItems)             //proverka za odrzuvanje na nizata na odredenata golemina
            {
                for (int i = 0; i < allitems.Count - noOfItems+1; i++)
                    allitems.RemoveAt(0);
                allitems.Add(item);
            }
            else
                allitems.Add(item);                                                     // add current "StringCoelction" to []allitems
            generateContextMenu();                                                  // regenerate the context menu
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)       // method to remove current lsitener from the .dll providith the same feture
                                                                                    // should be called before closing (exiting / terminating) the app
        {
            RemoveClipboardFormatListener(this.Handle);
        }

        private void btnSetText_Click(object sender, EventArgs e)           // old code used for debuging
        {
            if (lbStrngs.SelectedIndex != -1)
            {

                Clipboard.SetText(lbStrngs.SelectedItem.ToString());
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)    // show form when "some button is clicked"  *** neds atention to determinate when(which element should be clicked) it is trigered  ****
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)        // method to hide form when "Hide" from context_menu is clicked
        {
            WindowState = FormWindowState.Minimized;
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)   // methot to be executed when item in context menu is being clicked
                                                                                                     // by default it set's the data represented by clicked item back to clipboard
        {
            bool item_found = false;
            string name = e.ClickedItem.ToString();                                                   // get the text that is displayend on top of clicked item
            
            for (int i = 0; i < allitems.Count; i++)                                                  //  find the item in []allitems coresponting to clicked item
                                                                                                      // first we try to find items coresponding tot he name to it's absolute path
            {
                if (allitems[i] is StringCollection)
                {
                    if (MatchingSC(allitems[i], name))                                              // call method to retur true if string "name" is coresponding to object "allitems[i]", otherwise returns false
                    {
                        Clipboard.SetFileDropList(allitems[i] as StringCollection);
                        item_found = true;                                                      // if item coresponding to the name of clicked context_menu element by it's absolute path is found, change value to true
                    }
                } 
            }
            if (item_found == false)                                                            // if there is no item coresponding to clicked context menu element
            {
                Clipboard.SetText(name);                                                       // if it is not represented by apsolute apth, then coresponding item must be string
            }
        }

        private bool MatchingSC(object p, string name)                                          // method to return true if string "name" is coresponding to object "p" (object P must be of type "StringColection")
        {
            StringCollection sc = p as StringCollection;
            if (sc[0].ToString().Contains(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)      // click aply button
        {   
            // let's use numeric up down instead of textbox
            // noOfItems = Convert.ToInt16(textBoxNoOfCopiesToStore.Text)-1;
            noOfItems = (int)nudStoredItems.Value;
            generateContextMenu();
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SetPosition()          // method to calculate proper position of the form acording to screen size (resolution)
        {
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            width = resolution.Width;
            height = resolution.Height;

            if (rbPositionBotomLeft.Checked == true)
            {
                this.SetDesktopLocation(0, height - 600);
            }
            else if (rbPositionBotomRight.Checked == true)
            {
                this.SetDesktopLocation(width - 350, height - 550);
            }
            else if (rbPositionTopLeft.Checked == true)
            {
                this.SetDesktopLocation(0, 0);
            }
            else if (rbPositionTopRight.Checked == true)
            {
                this.SetDesktopLocation(width - 150, 0);
            }
        }

        private void rbSortByCategory_CheckedChanged(object sender, EventArgs e)        // when sort by category is checked then change status to enabled of all of the subategories
        {
            if (rbSortByCategory.Checked == true)
            {
                rbSortTextFirst.Enabled = true;
                rbSortFilesAndFoldersFirst.Enabled = true;
            }
            else
            {
                rbSortTextFirst.Enabled = false;
                rbSortFilesAndFoldersFirst.Enabled = false;
            }
        }

        private void nudStoredItems_ValueChanged(object sender, EventArgs e)
        {
            noOfItems = (int)nudStoredItems.Value;
        }

        private void rbPositionTopLeft_CheckedChanged(object sender, EventArgs e)
        {
            //this.SetPosition();
        }

        private void rbPositionTopRight_CheckedChanged(object sender, EventArgs e)
        {
            //this.SetPosition();
        }

        private void rbPositionBotomLeft_CheckedChanged(object sender, EventArgs e)
        {
           // this.SetPosition();
        }

        private void rbPositionBotomRight_CheckedChanged(object sender, EventArgs e)
        {
         //   this.SetPosition();
        }



    }
}


