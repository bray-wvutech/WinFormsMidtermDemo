using System.Runtime.CompilerServices;
using System.Security.Cryptography.Xml;

namespace WinFormsMidtermDemo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        cardPictureBox.Image = cardsImageList.Images[32];
    }

    private void ParamValueTester(int number)

    {
        number = 3;
    }

    private void Test()
    {
        int x = 1;
        ParamValueTester(x);
        int y = x;
        MessageBox.Show(y.ToString());
    }

    private void ParamValueTester2(out int number)
    {
        number = 3;
    }

    private void Test2()
    {
        int x = 1;
        ParamValueTester2(out x);
        int y = x;
        MessageBox.Show(y.ToString());
    }

    private void ParamValueTester3(int[] numbers)
    {
        numbers[0] = 27;
    }

    private void Test3()
    {
        int[] numArray = { 1, 2, 3 };
        ParamValueTester3(numArray);
        int y = numArray[0];
        MessageBox.Show(y.ToString());
    }

    private void ParamValueTester4(List<int> numbers)
    {
        numbers = null;
    }

    private void Test4()
    {
        List<int> numList = new List<int>() { 1, 2, 3 };
        ParamValueTester4(numList);
        int y = 0;
        if (numList != null)
        {
            y = numList[0];
        }
        MessageBox.Show(y.ToString());
    }

    private void Test5()
    {
        int[] array1 = new int[3] { 1, 2, 3 };
        int[] array2 = array1;
        array1[0] = 32;
        int y = array2[0];
        MessageBox.Show(y.ToString());
    }

    private void paramTest1Button_Click(object sender, EventArgs e)
    {
        Test();
    }

    private void paramTest2Button_Click(object sender, EventArgs e)
    {
        Test2();
    }

    private void paramTest3Button_Click(object sender, EventArgs e)
    {
        Test3();
    }

    private void paramTest4Button_Click(object sender, EventArgs e)
    {
        Test4();
    }

    private void paramTest5Button_Click(object sender, EventArgs e)
    {
        Test5();
    }

    private bool IsEqualNoCase(string? str1, string? str2)
    {
        if (str1.ToUpper() == str2.ToUpper())
        {
            return true;
        }
        return false;
    }

    private bool IsEqualNoCase2(string? str1, string? str2)
    {
        return string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
    }

    private bool IsEqualNoCase3(string? str1, string? str2)
    {
        // maybe you want this maybe you don't
        if ((str1 == null) && (str2 == null))
        {
            return true;
        }

        if ((str1 == null) || (str2 == null))
        {
            return false;
        }

        if (str1.ToUpper() == str2.ToUpper())
        {
            return true;
        }
        return false;
    }

    private enum Color { Red, Green, Blue }
    private string ColorToString(Color color)
    {
        return color.ToString();
    }

    private string ColorToString2(Color color)
    {
        switch (color)
        {
            case Color.Red:
                return "Red";
            case Color.Blue:
                return "Blue";
            case Color.Green:
                return "Green";
            default:
                return "";
        }
    }

    // STRUCT TESTS
    struct PersonStruct
    {
        public int age;
    }

    private void StructTest()
    {
        PersonStruct p1 = new PersonStruct();
        p1.age = 32;

        // even though they use new structs are VALUE types NOT reference types
        PersonStruct p2 = p1;
        p1.age = 75;
        MessageBox.Show(p2.age.ToString());

        // you can't directly compare structs
        // you will get an error
        //if (p1 == p2)
        //{
        //    MessageBox.Show("can't compare structs");
        //}

        StructParamTest(p2);
        MessageBox.Show(p2.age.ToString());
    }

    private void StructParamTest(PersonStruct p)
    {
        p.age = 99;
    }

    private void structAssignmentButton_Click(object sender, EventArgs e)
    {
        StructTest();
    }

    // DATE TIME TESTS
    private void DateTimeTest()
    {
        DateTime dt1 = DateTime.Now;
        DateTime dt2;
        dt2 = dt1;

        int[] a1 = new int[3];
        int[] a2 = a1;

        string dt1ptr = GetPtr(dt1);
        string dt2ptr = GetPtr(dt2);
        string a1ptr = GetPtr(a1);
        string a2ptr = GetPtr(a2);

        string msg = "";
        msg += $"dt1: {dt1.ToString()}\n";
        msg += $"dt2: {dt2.ToString()}\n";
        msg += $"dt1 ptr: {dt1ptr}\n";
        msg += $"dt2 ptr: {dt2ptr}\n";
        msg += $"a1 ptr: {a1ptr}\n";
        msg += $"a2 ptr: {a2ptr}\n";
        MessageBox.Show(msg);
    }

    public static string GetPtr(object a)
    {
        var ptr = Unsafe.As<object, IntPtr>(ref a);
        return $"0x{ptr:X}";
    }

    private void dateTimeButton_Click(object sender, EventArgs e)
    {
        DateTimeTest();
    }

    // OTHER STUFF
    private const string FILE_PATH = @"C:\Users\bray_\source\repos\2024 fall c sharp class\WinFormsMidtermDemo\WinFormsMidtermDemo\hands\";
    private void openButton_Click(object sender, EventArgs e)
    {
        mainSaveFileDialog.InitialDirectory = FILE_PATH;
        mainSaveFileDialog.DefaultExt = "txt";
        if (mainSaveFileDialog.ShowDialog() == DialogResult.OK)
        {

        }
    }

    public struct PhoneBookEntry
    {
        public string name;
        public string phone;
    }

    private const string PHONE_BOOK_PATH = @"C:\Users\bray_\source\repos\2024 fall c sharp class\WinFormsMidtermDemo\WinFormsMidtermDemo\hands\TextFile1.txt";
    //private List<PhoneBookEntry> entries = new List<PhoneBookEntry>();
    private Dictionary<string, PhoneBookEntry> entries = new Dictionary<string, PhoneBookEntry>();

    private void LoadPhoneBook()
    {
        try
        {
            using (var reader = new StreamReader(PHONE_BOOK_PATH))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line != null)
                    {
                        string[] tokens = line.Split(",");
                        PhoneBookEntry entry = new();
                        entry.name = tokens[0];
                        entry.phone = tokens[1];
                        entries.Add(entry.name, entry);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void EntriesToList()
    {
        personListBox.Items.Clear();
        foreach (var entry in entries)
        {
            personListBox.Items.Add(entry.Value.name);
        }
    }

    private void phoneButton_Click(object sender, EventArgs e)
    {
        LoadPhoneBook();
        EntriesToList();
    }

    private void personListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (personListBox.SelectedItem != null)
        {
            PhoneBookEntry entry;
            string? name = personListBox.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(name))
            {
                if (entries.TryGetValue(name, out entry))
                {
                    phoneLabel.Text = entry.phone;
                }
            }
        }
    }

    private Dictionary<string, string> phoneBookDict = new Dictionary<string, string>()
    {
        { "Bill", "555-1234" },
        { "Lisa", "555-6754" },
        { "Ted", "555-9876" }
    };

    void DictTest()
    {
    }

    private void dictTestButton_Click(object sender, EventArgs e)
    {
        DictTest();
    }
}
