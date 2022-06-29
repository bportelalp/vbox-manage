

using BP.Components.VBoxInterop;
using BP.Components.VBoxInterop.Common;

namespace BP.VBoxManage
{
    public partial class MainWindow : Form
    {
        List<VirtualMachine> vms;
        VirtualMachine CurrentVM;
        public MainWindow()
        {
            GetVirtualMachines();
            InitializeComponent();
        }

        private void GetVirtualMachines()
        {
            var vbox = new VirtualBox();
            vms = vbox.GetVMs().ToList();
            CurrentVM = vms.FirstOrDefault();
            CurrentVM.Output += WriteLog;
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            CurrentVM.GetState();
        }

        private void WriteLog(object? sender, LogEventArgs e)
        {
            BeginInvoke(() => logOutput.AppendText(Environment.NewLine + e.ToString()));
            
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            CurrentVM.StartVM();
        }

        private async void btnStop_Click(object sender, EventArgs e)
        {
            CurrentVM.SaveVM();
        }
    }
}