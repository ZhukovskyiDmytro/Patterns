using FactoryMethod.FactoryMethod.Creators;
using FactoryMethod.FactoryMethod.Products;
using System;
using System.Windows.Forms;

namespace FactoryMethod
{
    public partial class fHouse : Form
    {
        private IHouseCreator _houseCreator;
        private IHouse _house;

        IHouse Shape
        {
            get => _house;
            set
            {
                pbxHouseImage.Image = value?.GetImage();
                _house = value;
            }
        }

        public fHouse()
        {
            InitializeComponent();
        }

        private void rbHouseType_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton rb && rb.Checked)
            {
                switch (rb.Text)
                {
                    case "Concrete House":
                        _houseCreator = new ConcreteHouseCreator();
                        break;
                    case "Brick House":
                        _houseCreator = new BrickHouseCreator();
                        break;
                    case "Wood House":
                        _houseCreator = new WoodHouseCreator();
                        break;
                    default:
                        _houseCreator = null;
                        break;
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(_houseCreator == null)
            {
                MessageBox.Show("Please select a house type.");
                return;
            }

            Shape = _houseCreator.CreateHouse();
        }
    }
}
