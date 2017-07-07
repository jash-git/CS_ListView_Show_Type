using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;

namespace Article
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //Take imagelist for store images to use in listview.
            System.Windows.Forms.ImageList myImageList1 = new ImageList();
            //set the image size of which size images will be displayed in the listview.
            myImageList1.ImageSize = new Size(64, 64);

            //Now add the images into the imageList..
            myImageList1.Images.Add(Image.FromFile(@"01.PNG"));
            myImageList1.Images.Add(Image.FromFile(@"02.PNG"));
            myImageList1.Images.Add(Image.FromFile(@"03.PNG"));
            myImageList1.Images.Add(Image.FromFile(@"04.PNG"));
            myImageList1.Images.Add(Image.FromFile(@"05.PNG"));
            myImageList1.Images.Add(Image.FromFile(@"06.PNG"));
            myImageList1.Images.Add(Image.FromFile(@"07.PNG"));
            myImageList1.Images.Add(Image.FromFile(@"08.PNG"));
            myImageList1.Images.Add(Image.FromFile(@"09.PNG"));
            myImageList1.Images.Add(Image.FromFile(@"10.PNG"));
            
            

            //Take another imageList to also display in the listview..
            System.Windows.Forms.ImageList myImageList2 = new ImageList();
            //set the image size smaller than the first imageList...
            myImageList2.ImageSize = new Size(32, 32);
            
            //Add images into the second imageList...
            myImageList2.Images.Add(Image.FromFile(@"01.PNG"));
            myImageList2.Images.Add(Image.FromFile(@"02.PNG"));
            myImageList2.Images.Add(Image.FromFile(@"03.PNG"));
            myImageList2.Images.Add(Image.FromFile(@"04.PNG"));
            myImageList2.Images.Add(Image.FromFile(@"05.PNG"));
            myImageList2.Images.Add(Image.FromFile(@"06.PNG"));
            myImageList2.Images.Add(Image.FromFile(@"07.PNG"));
            myImageList2.Images.Add(Image.FromFile(@"08.PNG"));
            myImageList2.Images.Add(Image.FromFile(@"09.PNG"));
            myImageList2.Images.Add(Image.FromFile(@"10.PNG"));


            //Now assing First imageList as LargeImageList to the ListView...
            myListView.LargeImageList = myImageList1;

            //assing the second imageList as SmallImageList to the ListView...
            myListView.SmallImageList  = myImageList2;
            

            //Then Add the items to the Listview & also assign the image index to that item...
            myListView.Items.Add("Item 1", 0);
            myListView.Items.Add("Item 2", 1);
            myListView.Items.Add("Item 3", 2);
            myListView.Items.Add("Item 4", 3);
            myListView.Items.Add("Item 5", 4);
            myListView.Items.Add("Item 6", 5);
            myListView.Items.Add("Item 7", 6);
            myListView.Items.Add("Item 8", 7);
            myListView.Items.Add("Item 9", 8);
            myListView.Items.Add("Item 10", 9);


            //You can also create the Groups into the ListView. if you want to add the Groups into the Listview then below
            //code will helpful for you.
            //In the below code i have created two ListViewGroup with it's name & it's alignment in ListView...
            ListViewGroup myLVGroup1 = new ListViewGroup("First Five Group", HorizontalAlignment.Left);
            ListViewGroup myLVGroup2 = new ListViewGroup("Last Five Group", HorizontalAlignment.Left);
            //after creating the ListViewGroup as you want add that group to the ListView...
            myListView.Groups.AddRange(new ListViewGroup[] { myLVGroup1, myLVGroup2 });


            //Finally assign the each item in wich group...

            //In below code first five items will be in the First group..
            myListView.Items[0].Group = myListView.Groups[0];
            myListView.Items[1].Group = myListView.Groups[0];
            myListView.Items[2].Group = myListView.Groups[0];
            myListView.Items[3].Group = myListView.Groups[0];
            myListView.Items[4].Group = myListView.Groups[0];

            //Last Five items will be in the Second Group...
            myListView.Items[5].Group = myListView.Groups[1];
            myListView.Items[6].Group = myListView.Groups[1];
            myListView.Items[7].Group = myListView.Groups[1];
            myListView.Items[8].Group = myListView.Groups[1];
            myListView.Items[9].Group = myListView.Groups[1];
           
        }

        //When user will select the "Large Icon" RadioButton, then it will display items into Large Icon view...
        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLargeIcon.Checked == true)
            {
                myListView.View = View.LargeIcon;
            }
        }

        //When user will select the "List" RadioButton, then it will display items into List view...
        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            if (rbList.Checked == true)
            {
                myListView.View = View.List;
            }
        }

        //When user will select the "Small Icon" RadioButton, then it will display items into Small Icon view...
        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmallIcon.Checked == true)
            {
                myListView.View = View.SmallIcon;
            }
        }

        //When user will select the "Tile" RadioButton, then it will display items into Tile view...
        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTile.Checked == true)
            {
                myListView.View = View.Tile;
            }
        }


        //Finally it will display the selected item message box when user will select a particular item from the ListView...
        private void myListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in myListView.SelectedItems)
            {
                MessageBox.Show(item.Text.ToString());
            }
        }
    }
}