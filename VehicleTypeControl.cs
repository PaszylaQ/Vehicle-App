using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Windows.Forms.Design;

namespace VehicleApp
{
    public class VehicleTypeControl : PictureBox
    {
        private List<Image> VehicleTypeImages = new List<Image>();
        private readonly List<TypeOfVehicle> VehicleTypeNames = new List<TypeOfVehicle> { TypeOfVehicle.Car, TypeOfVehicle.Motorcycle, TypeOfVehicle.Truck };
        public event EventHandler ImageChanged;
        private int typeNumber;
        
        protected override void OnClick(EventArgs e)
        {
            CurrentType = VehicleTypeNames[(VehicleTypeNames.IndexOf(CurrentType) + 1) % 3];
            EventHandler handler = ImageChanged;
            handler?.Invoke(this, e);
        }

        [EditorAttribute(typeof(VehicleTypeEditor),
            typeof(System.Drawing.Design.UITypeEditor))]
        [Category("Vehicle Type")]
        [Browsable(true)]
        public TypeOfVehicle CurrentType
        {
            set
            {
                typeNumber = VehicleTypeNames.IndexOf(value);
                Image = VehicleTypeImages[typeNumber];
            }
            get { return VehicleTypeNames[typeNumber]; }
        }

        public VehicleTypeControl() : base()
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
            VehicleTypeImages.Add(Properties.Resources.Car);
            VehicleTypeImages.Add(Properties.Resources.Motorcycle);
            VehicleTypeImages.Add(Properties.Resources.Truck);
        }

        public VehicleTypeControl(TypeOfVehicle type) : base()
        {
            VehicleTypeImages.Add(Properties.Resources.Car);
            VehicleTypeImages.Add(Properties.Resources.Motorcycle);
            VehicleTypeImages.Add(Properties.Resources.Truck);
            CurrentType = type;
        }
    }
    class VehicleTypeEditor : System.Drawing.Design.UITypeEditor
    {

        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context,
        System.IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService edSvc =
            (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (edSvc != null)
            {
                VehicleTypeControl vehicleTypeControl = new VehicleTypeControl((TypeOfVehicle)value);
                vehicleTypeControl.Size = vehicleTypeControl.Image.Size;
                edSvc.DropDownControl(vehicleTypeControl);
                return vehicleTypeControl.CurrentType;
            }
            return value;
        }

    }
}
