using System.Collections;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace crystalrdlc
{
    class clsListViewSorter
    {

        //LISTVIEW COLUMN SORTER VARIABLES
        public static ListViewColumnSorter lvColumnSorter = null;

        public static void setComlumnSorter(ListView sListView)
        {
            lvColumnSorter = new ListViewColumnSorter();
            sListView.ListViewItemSorter = lvColumnSorter;
            sListView.Sorting = SortOrder.None;
            sListView.AutoArrange = true;
        }
    }

    public class ListViewColumnSorter : IComparer
    {
        private int ColumnToSort;

        private SortOrder OrderOfSort;

        private NumberCaseInsensitiveComparer ObjectCompare;
        private ImageTextComparer FirstObjectCompare;

        public ListViewColumnSorter()
        {
            // Initialize the column to '0'
            ColumnToSort = 0;

            // Initialize the sort order to 'none'
            //OrderOfSort = SortOrder.None;
            OrderOfSort = SortOrder.Ascending;

            // Initialize the CaseInsensitiveComparer object
            ObjectCompare = new NumberCaseInsensitiveComparer();//CaseInsensitiveComparer();
            FirstObjectCompare = new ImageTextComparer();
        }

        public int Compare(object x, object y)
        {
            int compareResult;
            ListViewItem listviewX, listviewY;

            // Cast the objects to be compared to ListViewItem objects
            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;

            if (ColumnToSort == 0) { compareResult = FirstObjectCompare.Compare(x, y); }
            else
            {
                // Compare the two items
                compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);
            }

            // Calculate correct return value based on object comparison
            if (OrderOfSort == SortOrder.Ascending)
            {
                // Ascending sort is selected, return normal result of compare operation
                return compareResult;
            }
            else if (OrderOfSort == SortOrder.Descending)
            {
                // Descending sort is selected, return negative result of compare operation
                return (-compareResult);
            }
            else
            {
                // Return '0' to indicate they are equal
                return 0;
            }
        }

        public int SortColumn
        {
            set { ColumnToSort = value; }
            get { return ColumnToSort; }
        }

        public SortOrder Order
        {
            set { OrderOfSort = value; }
            get { return OrderOfSort; }
        }

    }

    public class ImageTextComparer : IComparer
    {
        //private CaseInsensitiveComparer ObjectCompare;
        private NumberCaseInsensitiveComparer ObjectCompare;

        public ImageTextComparer()
        {
            // Initialize the CaseInsensitiveComparer object
            ObjectCompare = new NumberCaseInsensitiveComparer();//CaseInsensitiveComparer();
        }

        public int Compare(object x, object y)
        {
            //int compareResult;
            int image1, image2;
            ListViewItem listviewX, listviewY;

            // Cast the objects to be compared to ListViewItem objects
            listviewX = (ListViewItem)x;
            image1 = listviewX.ImageIndex;
            listviewY = (ListViewItem)y;
            image2 = listviewY.ImageIndex;

            if (image1 < image2) { return -1; }
            else if (image1 == image2) { return ObjectCompare.Compare(listviewX.Text, listviewY.Text); }
            else { return 1; }
        }
    }

    public class NumberCaseInsensitiveComparer : CaseInsensitiveComparer
    {
        public NumberCaseInsensitiveComparer() { }

        public new int Compare(object x, object y)
        {
            if ((x is System.String) && IsWholeNumber((string)x) && (y is System.String) && IsWholeNumber((string)y))
            {
                return base.Compare(System.Convert.ToInt32(x), System.Convert.ToInt32(y));
            }
            else { return base.Compare(x, y); }
        }

        private bool IsWholeNumber(string strNumber)
        {
            Regex objNotWholePattern = new Regex("[^0-9]");
            return !objNotWholePattern.IsMatch(strNumber);
        }
    }
}
