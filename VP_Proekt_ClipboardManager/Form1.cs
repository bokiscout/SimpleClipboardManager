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
        // [Serializable]
        public List<Object> allitems = new List<Object>();          // declare and initialize list of "Object", each item is something copied in clipboard but stored as "Object"... will need casting for later use
        public int noOfItems { get; set; }                          // variable to store maximum number of itemst to be stored
        int width { get; set; }                                     // width of the screen in pixels, used to determinate proper position of the form
        int height { get; set; }                                    // height of the screen in pixels, used to determinate proper position of the form
        bool closeApp{ get; set;}                                   // variable to store if app should be closed od red X btn click or not (minimized to system tray)

        String setap { get; set; }                                  // location where the setup file is located
        String history { get; set; }                                // location where history is saved
        String username { get; set; }                               // name of the active user
        String root { get; set; }                                   // Leter of disk drive where Windows is installed (ex: C, D, E...)

        public Form1()
        {   
            InitializeComponent();
            
            root = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
            history = root + @"Users\Public\clipboard\history.txt";
            setap = root + @"Users\Public\clipboard\lines.txt";

            AddClipboardFormatListener(this.Handle);                    // ClipBoard Listener
            
            // add some code to deal with initialization of "List<Object> allitemes"
            //
            //
            // code for dealing with initialization of "List<Object> allitemes" ends here
            noOfItems = (int)nudStoredItems.Value;              // intilize number of items acorting to value in form numeric updown
            SetPosition();                                      // call methot to initialize width and height values representing screen size
            closeApp = false;

            try{
                    fillForm();                                 // try to read config file   // if config file not found, loead form defaults
                    MessageBox.Show("Form filed from file");
                }
           catch (Exception ex)
                {
                    MessageBox.Show("Setap not found");
                }

            if (checkBoxRememberOnClose.Checked == true)
            {
                try
                {
                    fillHistory();
                    MessageBox.Show("History found");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("History not found");
                }
            }
        }



        ////////////////////////////////////////////////////////////////////////////////////////
        //
        //
        // Start initialization of fields neceserry for Clipboard Listener
        
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
        
        // End initialization of fields neceserry for Clipboard Listener
        //
        //
        ///////////////////////////////////////////////////////////////////////////////////////




        // The logic behind the clipboard listener
        // method to catch clipboard changes
        // ****     note1: this is recursive method!!!
        protected override void WndProc(ref Message m)
        {
            // note1: you see! this is recursive method!
            base.WndProc(ref m);

            if (m.Msg == WM_CLIPBOARDUPDATE)
            {
                if (Clipboard.ContainsFileDropList() && checkBoxItems.Checked)
                {
                    StringCollection item;
                    item = Clipboard.GetFileDropList();
                    if (item.Count == 1)
                    {
                        // add to context menu as last item
                        addToContextMenu(item);                     
                        // add more code to produce specific behaviour for adding files (documents)
                        // should be implemented ****    ****    ****
                    }
                }
                // if 'else' is reached then current clipboard item is string for shure
                else
                {
                    if (Clipboard.ContainsText() && checkBoxText.Checked)
                    {
                        string name = Clipboard.GetText();
                        addToContextMenu(name);
                        // *****    ****    **** 
                        // add more code here to produce specific behaviour for adding strings in clipboard,
                        // adding in context menu and deleteing duplicates   
                    }
                }
            }
        }


        // note1: this method might trow Exception if file is missing
        // note2: the exception is handled on formLoad
        private void fillHistory()
        {
            string line;
            System.IO.StreamReader reader = new System.IO.StreamReader(history);

            line = reader.ReadLine();
            while (line != null)
            {
                // 0 = file or folder had to be serialized but it was not
                // note3: go to "HistorySerialization()" to see the implementation
                if (line != "0")
                {
                    allitems.Add(line);
                }
                line = reader.ReadLine();
            }

            reader.Close();
            generateContextMenu();
        }


        // note1: this method might trow Exception if file is missing
        // note2: the exception is handled on formLoad
        private void fillForm()
        {
            String line;
            System.IO.StreamReader reader = new System.IO.StreamReader(setap);

            for (int i = 0; i < 12; i++)
            {
                line = reader.ReadLine();

                // 0 < i < 11
                // each case for i test some property
                // ex: i=0 test if form should be in top left corner,
                // ex: i=1 test if form should be in top right corner...
                switch (i)
                {
                    case 0:
                        if (line == "1")
                        {
                            rbPositionTopLeft.Checked = true;
                        }
                        else
                        {
                            rbPositionTopLeft.Checked = false;
                        }
                        break;
                    case 1:
                        if (line == "1")
                        {
                            rbPositionTopRight.Checked = true;
                        }
                        else
                        {
                            rbPositionTopRight.Checked = false;
                        }
                        break;
                    case 2:
                        if (line == "1")
                        {
                            rbPositionBotomLeft.Checked = true;
                        }
                        else
                        {
                            rbPositionBotomLeft.Checked = false;
                        }
                        break;
                    case 3:
                        if (line == "1")
                        {
                            rbPositionBotomRight.Checked = true;
                        }
                        else
                        {
                            rbPositionBotomRight.Checked = false;
                        }
                        break;
                    case 4:
                        if (line == "1")
                        {
                            rbSortByTime.Checked = true;
                        }
                        else
                        {
                            rbSortByTime.Checked = false;
                        }
                        break;
                    case 5:
                        if (line == "1")
                        {
                            rbSortByCategory.Checked = true;
                        }
                        else
                        {
                            rbSortByCategory.Checked = false;
                        }
                        break;
                    case 6:
                        if (line == "1")
                        {
                            rbSortTextFirst.Checked = true;
                        }
                        else
                        {
                            rbSortTextFirst.Checked = false;
                        }
                        break;
                    case 7:
                        if (line == "1")
                        {
                            rbSortFilesAndFoldersFirst.Checked = true;
                        }
                        else
                        {
                            rbSortFilesAndFoldersFirst.Checked = false;
                        }
                        break;
                    case 8:
                        if (line == "1")
                        {
                            checkBoxText.Checked = true;
                        }
                        else
                        {
                            checkBoxText.Checked = false;
                        }
                        break;
                    case 9:
                        if (line == "1")
                        {
                            checkBoxItems.Checked = true;
                        }
                        else
                        {
                            checkBoxItems.Checked = false;
                        }
                        break;
                    case 10:
                        nudStoredItems.Value = Int32.Parse(line);
                        break;
                    case 11:
                        if (line == "1")
                        {
                            checkBoxRememberOnClose.Checked = true;
                        }
                        else
                        {
                            checkBoxRememberOnClose.Checked = false;
                        }
                        break;
                }
            }
            reader.Close();
            // if this code is reached, config file was present
            // that equals program has been running in the past
            // so we put it in systemtray
            this.WindowState = FormWindowState.Minimized;
        }

        // method to close app from strip menu (top meny)
        private void stripMenuClose_Click(object sender, EventArgs e)
        {
            closeApp = true;
            this.Close();
        }


        // method to clear history from strip menu (top meny)
        private void stripMenuClear_Click(object sender, EventArgs e)
        {
            // note1: "i" is not incrementig
            // we are removing item at position 0 until there are no more items
            for (int i = 0; i < allitems.Count;)
            {
                allitems.RemoveAt(0);
            }

            generateContextMenu();
        }


        // tray icon doubleclick
        // show (restore) form if it is hiden
        private void notifyTryIcon_MouseDoubleClick(object sender, MouseEventArgs e)                 
        {
            this.SetPosition();
            Show();
            WindowState = FormWindowState.Normal;
        }


        // method to add string in context menu
        // note1: this method has one more signature accepting 'StringCollection'
        private void addToContextMenu(string name)  
        {   
            //<generate more specific behaviour>
            // if(checkbox_delete_duplicates)....
            //
            // else...
            // <more specifici behaviour ends here>
            for (int i = 0; i < allitems.Count; i++)
            {
                // by default we delete duplicates
                int duplikat = ((String.CompareOrdinal(allitems[i].ToString(), name)));
                if (duplikat == 0)
                {
                    allitems.RemoveAt(i);
                    // probably value of i should be decremented after deleting item
                    // otherwise some elements might be skipped
                    // or might not becouse there are no more than one duplicate
                    // need few tests here
                }
            } 
            // if there were any duplicates now they are gone

            // if we have maxiumim number of elements, delete oldest one and add new one
            if (allitems.Count > noOfItems)
            {
                for (int i = 0; i < allitems.Count - noOfItems + 1; i++)
                {
                    allitems.RemoveAt(0);
                }
                allitems.Add(name);
                // here might be bug, probably missing brackets, need more testing here
            }
            else
            {
                allitems.Add(name);
            }
            sortAllItems();
            generateContextMenu();
        }

        // method to add 'StringColection' in context menu
        // note1: this method has one more signature accepting 'String'
        private void addToContextMenu(StringCollection item)
        {
            // by default we remove duplicates
            // write more code to get more specific begavior
            //
            //

            // check for existing files equal to one that should be added
            for (int i = 0; i < allitems.Count; i++)            
            {
                if (allitems[i] is StringCollection)
                {
                    // asume that there are no duplicates       
                    bool duplikat = false;

                    // myStringColection provides overrided CompareTo() method
                    //
                    // default compare to can not be used becouse of invalid casting
                    // parrent (Object) can not be casted to child (StringColection)
                    // solution is:
                    // "new class that accept argument of type "StringColection"
                    // and implementing it's own "Equals()" method"
                    myStringColection mscItem = new myStringColection(item);
      
                    duplikat = mscItem.Equals(allitems[i]);
                    if (duplikat)
                    {
                        // remove i'th items if it is equal to one that needs to be added
                        // new item will be added last in the list later (probably)         ****    ****    ****
                        allitems.RemoveAt(i);                               
                    }
                }
            }
            // if there were duplicates now they are gone

            // proverka za odrzuvanje na nizata na odredenata golemina
            // if we have maxiumim number of elements, delete oldest one and add new one
            if (allitems.Count > noOfItems)            
            {
                for (int i = 0; i < allitems.Count - noOfItems + 1; i++)
                {
                    allitems.RemoveAt(0);
                }
                allitems.Add(item);
            }
            else
            {
                allitems.Add(item);
            } 
            sortAllItems();
            generateContextMenu();
        }

        
        // this methot will call other sorting method
        // it depends on which sorting method is checked on the form
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


        // sorting method
        // first files and folders, then strings
        private void SortAllItemsFilesAndFoldersFirst()
        {
            // generate empty list
            List<object> newlist = new List<object>();

            for (int i = 0; i < allitems.Count; i++)
            {
                if (allitems[i] is StringCollection)
                {
                    newlist.Add(allitems[i]);
                }
            }
            // all files and folders are added

            // now add text
            for (int i = 0; i < allitems.Count; i++)
            {
                if (!(allitems[i] is StringCollection))
                {
                    newlist.Add(allitems[i]);
                }
            }
            // text has been added

            // asign new (temporary) list to old one
            // 31.01.2016 : why the hell temporaray? need more investigation, same as in other sorting method
            allitems = newlist;     
        }


        // sorting method
        // first text, then files and folders
        private void SortAllItemsTextFirst()
        {
            List<object> newlist = new List<object>();
            
            // add text to the list
            for (int i = 0; i < allitems.Count; i++)
            {
                if (!(allitems[i] is StringCollection)) 
                {
                    newlist.Add(allitems[i]);
                }
            }
            // all text items has been added

            // now add Files and Folders
            for (int i = 0; i < allitems.Count; i++)
            {
                if (allitems[i] is StringCollection)
                {
                    newlist.Add(allitems[i]);
                }
            }
            // Files and Folders has been added

            // asign new (temporary) list to old one
            // 31.01.2016 : why the hell temporaray? need more investigation, same as in other sorting method
            allitems = newlist;
        }


        // method to generate context menu
        // this is accessable by right click on system try icon
        private void generateContextMenu()                                                      
        {
            lbStrngs.Items.Clear();
            lbItems.Items.Clear();

            // first remove all items from context menu
            // note1: variable "i" is not incrementing
            // note2: '.Count' return smaller integer in every next iteration
            for (int i = 3; i < contextMenuStrip1.Items.Count; )                                           
            {
                contextMenuStrip1.Items.RemoveAt(i);
            }
            // all items deleteted

            // now add items to contextmenu
            for (int i = 0; i < allitems.Count; i++)
            {
                if (allitems[i] is StringCollection)
                {
                    StringCollection sc = allitems[i] as StringCollection;
                    if (sc.Count > 1)
                        // probably bad handling of multiple files          ****        ****        ****
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
                        int index = s.LastIndexOf("\\");        //get the indexot na posednoto "/" pa nataka
                        string name = s.Substring(index + 1);   //make substring kako substring
                        lbItems.Items.Add(name);
                        contextMenuStrip1.Items.Add(name);
                    }
                }
                else
                {
                    string name = allitems[i].ToString();
                    name = name.Substring(0, 15);       // name can be maximum of 15 chars long
                    lbStrngs.Items.Add(name);
                    contextMenuStrip1.Items.Add(name);
                }
            }
        }

        // method to handle closing of app
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)             
        {
            // prevent closing from red X button placed on window frame, but allow closing from context menu
            if (closeApp == true || e.CloseReason != CloseReason.UserClosing)
            {
                RemoveClipboardFormatListener(this.Handle);
                mySerialization();
                if (checkBoxRememberOnClose.Checked == true)
                {
                    historySerialization();
                }
                return;
               
            }
            e.Cancel = true;
            Hide();
        }


        // serialize history as plain text
        private void historySerialization()
        {
           int size = allitems.Count;
           string[] tmp = new string[size];
            for (int i = 0; i < allitems.Count; i++)
            {
                if (!(allitems[i] is StringCollection))
                {
                    tmp[i] = allitems[i].ToString();
                }
                else
                {
                    // 0 = file or folder, we can not serialize them as plain text
                    tmp[i] = "0";
                }
            }
            System.IO.File.WriteAllLines(history, tmp);
        }


        // serialize form state
        // ex: state of checkboxes, state of radiobuttons etc...
        private void mySerialization()
        {
            // ***    ****   ***  why tmp[] is 13 objects here, but on deserialiation it is only 11?
            // need more investigation
            string[] tmp = new string[13];

            bool checktl = rbPositionTopLeft.Checked;
            if(checktl)
            {
                tmp[0] = "1";
            }
            else
            {
                tmp[0] = "0";
            }

            bool checktr = rbPositionTopRight.Checked;
            if (checktr)
            {
                tmp[1] = "1";
            }
            else
            {
                tmp[1] = "0";
            }

            bool checkbl = rbPositionBotomLeft.Checked;
            if (checkbl)
            {
                tmp[2] = "1";
            }
            else
            {
                tmp[2] = "0";
            }

            bool checkbr = rbPositionBotomRight.Checked;
            if (checkbr)
            {
                tmp[3] = "1";
            }
            else
            {
                tmp[3] = "0";
            }

            bool checkByItems = rbSortByTime.Checked;
            if (checkByItems)
            {
                tmp[4] = "1";
            }
            else
            {
                tmp[4] = "0";
            }

            bool checkByCategory = rbSortByCategory.Checked;
            if (checkByCategory)
            {
                tmp[5] = "1";
            }
            else
            {
                tmp[5] = "0";
            }

            bool checkTextFirst = rbSortTextFirst.Checked;
            if (checkTextFirst)
            {
                tmp[6] = "1";
            }
            else
            {
                tmp[6] = "0";
            }

            bool checkFilesFirst = rbSortFilesAndFoldersFirst.Checked;
            if (checkFilesFirst)
            {
                tmp[7] = "1";
            }
            else
            {
                tmp[7] = "0";
            }

            bool checkText = checkBoxText.Checked;
            if (checkText)
            {
                tmp[8] = "1";
            }
            else
            {
                tmp[8] = "0";
            }

            bool checkFiles = checkBoxItems.Checked;
            if (checkFiles)
            {
                tmp[9] = "1";
            }
            else
            {
                tmp[9] = "0";
            }

            int nitems = (int)nudStoredItems.Value;
            tmp[10] = nitems.ToString();

            bool checkHistory = checkBoxRememberOnClose.Checked;
            if (checkHistory)
            {
                tmp[11] = "1";
            }
            else
            {
                tmp[11] = "0";
            }

            System.IO.File.WriteAllLines(setap, tmp);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)                // method to close form when clicked "Close" button from context menu
        {
            closeApp = true;
            this.Close();                                                                   // call "Form1_FormClosing_1()"
        }


        private void showToolStripMenuItem_Click(object sender, EventArgs e)    // show form when "some button is clicked"  *** neds atention to determinate when(which element should be clicked) it is trigered  ****
        {
            Show();
            WindowState = FormWindowState.Normal;
            this.SetPosition();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)        // method to hide form when "Hide" from context_menu is clicked
        {
            WindowState = FormWindowState.Minimized;
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)   // methot to be executed when item in context menu is being clicked
                                                                                                     // by default it set's the data represented by clicked item back to clipboard
        {
            if (e.ClickedItem.Name == "showToolStripMenuItem" || e.ClickedItem.Name == "hideToolStripMenuItem" || e.ClickedItem.Name == "closeToolStripMenuItem")          // do not take action when Close, Show or Hide is pressed
            {
                return;
            }

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


        private void SetPosition()          // method to calculate proper position of the form acording to screen size (resolution)
        {
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            width = resolution.Width;
            height = resolution.Height;

            if (rbPositionBotomLeft.Checked == true)
            {
                this.SetDesktopLocation(0, height - 510);
            }
            else if (rbPositionBotomRight.Checked == true)
            {
                this.SetDesktopLocation(width - 590, height - 510);
            }
            else if (rbPositionTopLeft.Checked == true)
            {
                this.SetDesktopLocation(0, 0);
            }
            else if (rbPositionTopRight.Checked == true)
            {
                this.SetDesktopLocation(width - 590, 0);
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
            this.SetPosition();
        }

        private void rbPositionTopRight_CheckedChanged(object sender, EventArgs e)
        {
            this.SetPosition();
        }

        private void rbPositionBotomLeft_CheckedChanged(object sender, EventArgs e)
        {
           this.SetPosition();
        }

        private void rbPositionBotomRight_CheckedChanged(object sender, EventArgs e)
        {
            this.SetPosition();
        }

        private void notifyTryIcon_MouseClick(object sender, MouseEventArgs e)              // use left click to show context menu isntead of right click
        {
           // Point mouseLocation = Cursor.Position;
            // contextMenuStrip1.Show(mouseLocation);
            // otifyTryIcon.MouseClick += MouseButtons.Right;
           // ContextMenuStrip.Show(notifyTryIcon.ContextMenuStrip, 10, 12);
            // notifyTryIcon_MouseDoubleClick(null, null);
            MouseButtons button = MouseButtons.Right;

            if (e.Button == MouseButtons.Left){
                // this.notifyTryIcon.ContextMenuStrip.Show();
            }
        }

        // this will hide window frame
        // without this, when we minimize to try, the frame is still shown
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

    }
}


