using MailAbstractFactory.AFactory.ALevel;
using MailAbstractFactory.AFactory.Standard;
using MailAbstractFactory.AFactory.Digital;
using MailAbstractFactory.AFactory.Express;
using System;
using System.Windows.Forms;

namespace MailAbstractFactory
{
    public partial class fMail : Form
    {
        //fields
        private string flowerType = null;

        private IMailFactory mailFactory;
        private IParcel parcel;
        private ITracker tracker;
        private ILetter letter;

        //properties
        private IParcel Parcel
        {
            get => parcel;
            set
            {
                if (value != null)
                {
                    pbxParcel.Image = value.Appearance;
                }

                parcel = value;
            }
        }
        private ITracker Tracker
        {
            get => tracker;
            set
            {
                if (value != null)
                {
                    pbxTracker.Image = value.Appearance;
                }

                tracker = value;
            }
        }
        private ILetter Letter
        {
            get => letter;
            set
            {
                if (value != null)
                {
                    pbxLetter.Image = value.Appearance;
                }

                letter = value;
            }
        }

        public fMail()
        {
            InitializeComponent();
        }

        //methods
        private void rbMailType_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton rb && rb.Checked)
            {
                switch (rb.Text)
                {
                        case "Standard":
                            mailFactory = new StandardFactory();
                            break;
                        case "Express":
                            mailFactory = new ExpressFactory();
                            break;
                        case "Digital":
                            mailFactory = new DigitalFactory();
                            break;
                        default:
                            mailFactory = null;
                            break;
                    
                }
            }
        }

        private void rbFlower_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                flowerType = rb.Text;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(mailFactory == null || flowerType == null)
            {
                MessageBox.Show("Please select a flower type and a flower.");
                return;
            }

            switch(flowerType)
            {
                case "Parcel":
                    Parcel = mailFactory.CreateParcel();
                    break;
                case "Tracker":
                    Tracker = mailFactory.CreateTracker();
                    break;
                case "Letter":
                    Letter = mailFactory.CreateLetter();
                    break;

                default:
                    MessageBox.Show("Unknown flower type.");
                    return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
