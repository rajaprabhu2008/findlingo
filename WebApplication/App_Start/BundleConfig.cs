using System.Web.Optimization;

namespace WebApplication
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterLayout(bundles);

            RegisterShared(bundles);

            RegisterAccount(bundles);

            RegisterHome(bundles);

            RegisterCharts(bundles);

            RegisterWidgets(bundles);

            RegisterElements(bundles);

            RegisterForms(bundles);

            RegisterTables(bundles);

            RegisterCalendar(bundles);

            RegisterMailbox(bundles);

            RegisterExamples(bundles);

            RegisterDocumentation(bundles);

            BundleTable.EnableOptimizations = true;
        }

        private static void RegisterDocumentation(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/Scripts/Documentation/menu").Include(
                "~/Scripts/Documentation/Documentation-menu.js"));
        }

        private static void RegisterExamples(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/Scripts/Examples/Blank/menu").Include(
                "~/Scripts/Examples/Blank-menu.js"));

            bundles.Add(new Bundle("~/Scripts/Examples/Invoice/menu").Include(
                "~/Scripts/Examples/Invoice-menu.js"));

            bundles.Add(new Bundle("~/Scripts/Examples/Lockscreen/menu").Include(
                "~/Scripts/Examples/Lockscreen-menu.js"));

            bundles.Add(new Bundle("~/Scripts/Examples/Login").Include(
                "~/Scripts/Examples/Login.js"));

            bundles.Add(new Bundle("~/Scripts/Examples/Login/menu").Include(
                "~/Scripts/Examples/Login-menu.js"));

            bundles.Add(new Bundle("~/Scripts/Examples/P404/menu").Include(
                "~/Scripts/Examples/P404-menu.js"));

            bundles.Add(new Bundle("~/Scripts/Examples/P500/menu").Include(
                "~/Scripts/Examples/P500-menu.js"));

            bundles.Add(new Bundle("~/Scripts/Examples/Pace").Include(
                "~/Scripts/Examples/Pace.js"));

            bundles.Add(new Bundle("~/Scripts/Examples/Pace/menu").Include(
                "~/Scripts/Examples/Pace-menu.js"));

            bundles.Add(new Bundle("~/Scripts/Examples/ProfileEx/menu").Include(
                "~/Scripts/Examples/ProfileEx-menu.js"));

            bundles.Add(new Bundle("~/Scripts/Examples/Register").Include(
                "~/Scripts/Examples/Register.js"));

            bundles.Add(new Bundle("~/Scripts/Examples/Register/menu").Include(
                "~/Scripts/Examples/Register-menu.js"));
        }

        private static void RegisterMailbox(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/Scripts/Mailbox/Inbox").Include(
                "~/Scripts/Mailbox/Inbox.js"));

            bundles.Add(new Bundle("~/Scripts/Mailbox/Inbox/menu").Include(
                "~/Scripts/Mailbox/Inbox-menu.js"));
            
            bundles.Add(new Bundle("~/Scripts/Mailbox/Compose").Include(
                "~/Scripts/Mailbox/Compose.js"));

            bundles.Add(new Bundle("~/Scripts/Mailbox/Compose/menu").Include(
               "~/Scripts/Mailbox/Compose-menu.js"));

            bundles.Add(new Bundle("~/Scripts/Mailbox/Read/menu").Include(
                "~/Scripts/Mailbox/Read-menu.js"));
        }

        private static void RegisterCalendar(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/Scripts/Calendar").Include(
                "~/Scripts/Calendar/Calendar.js"));

            bundles.Add(new Bundle("~/Scripts/Calendar/menu").Include(
                "~/Scripts/Calendar/Calendar-menu.js"));
        }

        private static void RegisterTables(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/Scripts/Tables/Simple/menu").Include(
                "~/Scripts/Tables/Simple-menu.js"));

            bundles.Add(new Bundle("~/Scripts/Tables/Data").Include(
                "~/Scripts/Tables/Data.js"));

            bundles.Add(new Bundle("~/Scripts/Tables/Data/menu").Include(
                "~/Scripts/Tables/Data-menu.js"));
        }

        private static void RegisterForms(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/Scripts/Forms/Advanced").Include(
                "~/Scripts/Forms/Advanced.js"));

            bundles.Add(new Bundle("~/Scripts/Forms/Advanced/menu").Include(
                "~/Scripts/Forms/Advanced-menu.js"));

            bundles.Add(new Bundle("~/Scripts/Forms/Editors").Include(
                "~/Scripts/Forms/Editors.js"));

            bundles.Add(new Bundle("~/Scripts/Forms/Editors/menu").Include(
                "~/Scripts/Forms/Editors-menu.js"));


            bundles.Add(new Bundle("~/Scripts/Forms/General/menu").Include(
                "~/Scripts/Forms/General-menu.js"));
        }

        private static void RegisterElements(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/Scripts/Elements/Buttons/menu").Include(
                "~/Scripts/Elements/Buttons-menu.js"));

            bundles.Add(new Bundle("~/Scripts/Elements/General/menu").Include(
                "~/Scripts/Elements/General-menu.js"));

            bundles.Add(new StyleBundle("~/Styles/Elements/General").Include(
                "~/Styles/Elements/General.css"));

            bundles.Add(new Bundle("~/Scripts/Elements/Icons/menu").Include(
                "~/Scripts/Elements/Icons-menu.js"));

            bundles.Add(new StyleBundle("~/Styles/Elements/Icons").Include(
                "~/Styles/Elements/Icons.css"));

            bundles.Add(new Bundle("~/Scripts/Elements/Modals/menu").Include(
                "~/Scripts/Elements/Modals-menu.js"));

            bundles.Add(new StyleBundle("~/Styles/Elements/Modals").Include(
                "~/Styles/Elements/Modals.css"));

            bundles.Add(new Bundle("~/Scripts/Elements/Sliders").Include(
                "~/Scripts/Elements/Sliders.js"));

            bundles.Add(new Bundle("~/Scripts/Elements/Sliders/menu").Include(
                "~/Scripts/Elements/Sliders-menu.js"));
            
            bundles.Add(new Bundle("~/Scripts/Elements/Timeline/menu").Include(
                "~/Scripts/Elements/Timeline-menu.js"));
        }

        private static void RegisterWidgets(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/Scripts/Widgets/menu").Include(
                "~/Scripts/Widgets/Widgets-menu.js"));
        }

        private static void RegisterCharts(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/Scripts/Charts/ChartsJs").Include(
                "~/Scripts/Charts/ChartsJs.js"));
            bundles.Add(new Bundle("~/Scripts/Charts/ChartsJs/menu").Include(
                            "~/Scripts/Charts/ChartsJs-menu.js"));

            bundles.Add(new Bundle("~/Scripts/Charts/Morris").Include(
                "~/Scripts/Charts/Morris.js"));

            bundles.Add(new Bundle("~/Scripts/Charts/Morris/menu").Include(
                "~/Scripts/Charts/Morris-menu.js"));

            bundles.Add(new Bundle("~/Scripts/Charts/Flot").Include(
                "~/Scripts/Charts/Flot.js"));

            bundles.Add(new Bundle("~/Scripts/Charts/Flot/menu").Include(
                "~/Scripts/Charts/Flot-menu.js"));

            bundles.Add(new Bundle("~/Scripts/Charts/Inline").Include(
                "~/Scripts/Charts/Inline.js"));

            bundles.Add(new Bundle("~/Scripts/Charts/Inline/menu").Include(
                "~/Scripts/Charts/Inline-menu.js"));
        }

        private static void RegisterHome(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/Scripts/Home/DashboardV1").Include(
                "~/Scripts/Home/DashboardV1.js"));
            bundles.Add(new Bundle("~/Scripts/Home/DashboardV1/menu").Include(
                "~/Scripts/Home/DashboardV1-menu.js"));

            bundles.Add(new Bundle("~/Scripts/Home/DashboardV2").Include(
                "~/Scripts/Home/DashboardV2.js"));
            bundles.Add(new Bundle("~/Scripts/Home/DashboardV2/menu").Include(
                "~/Scripts/Home/DashboardV2-menu.js"));
        }

        private static void RegisterAccount(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/Scripts/Account/Login").Include(
                "~/Scripts/Account/Login.js"));

            bundles.Add(new Bundle("~/Scripts/Account/Register").Include(
                "~/Scripts/Account/Register.js"));
        }

        private static void RegisterShared(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/Scripts/Shared/_Layout").Include(
                "~/Scripts/Shared/_Layout.js"));
        }

        private static void RegisterLayout(BundleCollection bundles)
        {
            
            bundles.Add(new Bundle("~/AdminLTE/bootstrap/jsboot").Include(
                "~/AdminLTE/bootstrap/js/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/bootstrap/cssboot").Include(
                "~/AdminLTE/bootstrap/css/bootstrap.min.css"));
            
            // dist
            bundles.Add(new Bundle("~/AdminLTE/dist/jsboot").Include(
                "~/AdminLTE/dist/js/app.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/dist/cssboot").Include(
                "~/AdminLTE/dist/css/admin-lte.min.css"));

            bundles.Add(new StyleBundle("~/AdminLTE/dist/css/skinsboot").Include(
                "~/AdminLTE/dist/css/skins/_all-skins.min.css"));

            // documentation
            bundles.Add(new Bundle("~/AdminLTE/documentation/jsboot").Include(
                "~/AdminLTE/documentation/js/docs.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/documentation/cssboot").Include(
                "~/AdminLTE/documentation/css/style.css"));

            // plugins | bootstrap-slider
            bundles.Add(new Bundle("~/AdminLTE/plugins/bootstrap-slider/jsboot").Include(
                                        "~/AdminLTE/plugins/bootstrap-slider/js/bootstrap-slider.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/bootstrap-slider/cssboot").Include(
                                        "~/AdminLTE/plugins/bootstrap-slider/css/slider.css"));

            // plugins | bootstrap-wysihtml5
            bundles.Add(new Bundle("~/AdminLTE/plugins/bootstrap-wysihtml5/jsboot").Include(
                                         "~/AdminLTE/plugins/bootstrap-wysihtml5/js/bootstrap3-wysihtml5.all.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/bootstrap-wysihtml5/cssboot").Include(
                                        "~/AdminLTE/plugins/bootstrap-wysihtml5/css/bootstrap3-wysihtml5.min.css"));

            // plugins | chartjs
            bundles.Add(new Bundle("~/AdminLTE/plugins/chartjs/jsboot").Include(
                                         "~/AdminLTE/plugins/chartjs/js/chart.min.js"));

            // plugins | ckeditor
            bundles.Add(new Bundle("~/AdminLTE/plugins/ckeditor/jsboot").Include(
                                         "~/AdminLTE/plugins/ckeditor/js/ckeditor.js"));

            // plugins | colorpicker
            bundles.Add(new Bundle("~/AdminLTE/plugins/colorpicker/jsboot").Include(
                                         "~/AdminLTE/plugins/colorpicker/js/bootstrap-colorpicker.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/colorpicker/cssboot").Include(
                                        "~/AdminLTE/plugins/colorpicker/css/bootstrap-colorpicker.css"));

            // plugins | datatables
            bundles.Add(new Bundle("~/AdminLTE/plugins/datatables/jsboot").Include(
                                         "~/AdminLTE/plugins/datatables/js/jquery.dataTables.min.js",
                                         "~/AdminLTE/plugins/datatables/js/dataTables.bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/datatables/cssboot").Include(
                                        "~/AdminLTE/plugins/datatables/css/dataTables.bootstrap.css"));

            // plugins | datepicker
            bundles.Add(new Bundle("~/AdminLTE/plugins/datepicker/jsboot").Include(
                                         "~/AdminLTE/plugins/datepicker/js/bootstrap-datepicker.js",
                                         "~/AdminLTE/plugins/datepicker/js/locales/bootstrap-datepicker*"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/datepicker/cssboot").Include(
                                        "~/AdminLTE/plugins/datepicker/css/datepicker3.css"));

            // plugins | daterangepicker
            bundles.Add(new Bundle("~/AdminLTE/plugins/daterangepicker/jsboot").Include(
                                         "~/AdminLTE/plugins/daterangepicker/js/moment.min.js",
                                         "~/AdminLTE/plugins/daterangepicker/js/daterangepicker.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/daterangepicker/cssboot").Include(
                                        "~/AdminLTE/plugins/daterangepicker/css/daterangepicker-bs3.css"));

            // plugins | fastclick
            bundles.Add(new Bundle("~/AdminLTE/plugins/fastclick/jsboot").Include(
                                         "~/AdminLTE/plugins/fastclick/js/fastclick.min.js"));

            // plugins | flot
            bundles.Add(new Bundle("~/AdminLTE/plugins/flot/jsboot").Include(
                                         "~/AdminLTE/plugins/flot/js/jquery.flot.min.js",
                                         "~/AdminLTE/plugins/flot/js/jquery.flot.resize.min.js",
                                         "~/AdminLTE/plugins/flot/js/jquery.flot.pie.min.js",
                                         "~/AdminLTE/plugins/flot/js/jquery.flot.categories.min.js"));

            // plugins | font-awesome
            bundles.Add(new StyleBundle("~/AdminLTE/plugins/font-awesome/cssboot", "http://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.0.3/css/font-awesome.css"));//.Include(
                                       // "~/AdminLTE/plugins/font-awesome/css/font-awesome.min.css"));

            // plugins | fullcalendar
            bundles.Add(new Bundle("~/AdminLTE/plugins/fullcalendar/jsboot").Include(
                                         "~/AdminLTE/plugins/fullcalendar/js/fullcalendar.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/fullcalendar/cssboot").Include(
                                        "~/AdminLTE/plugins/fullcalendar/css/fullcalendar.min.css"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/fullcalendar/css/printboot").Include(
                                        "~/AdminLTE/plugins/fullcalendar/css/print/fullcalendar.print.css"));

            // plugins | icheck
            bundles.Add(new Bundle("~/AdminLTE/plugins/icheck/jsboot").Include(
                                         "~/AdminLTE/plugins/icheck/js/icheck.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/icheck/cssboot").Include(
                                        "~/AdminLTE/plugins/icheck/css/all.css"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/icheck/css/flatboot").Include(
                                        "~/AdminLTE/plugins/icheck/css/flat/flat.css"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/icheck/css/sqare/blueboot").Include(
                                        "~/AdminLTE/plugins/icheck/css/sqare/blue.css"));

            // plugins | input-mask
            bundles.Add(new Bundle("~/AdminLTE/plugins/input-mask/jsboot").Include(
                                         "~/AdminLTE/plugins/input-mask/js/jquery.inputmask.js",
                                         "~/AdminLTE/plugins/input-mask/js/jquery.inputmask.date.extensions.js",
                                         "~/AdminLTE/plugins/input-mask/js/jquery.inputmask.extensions.js"));

            // plugins | ionicons
            bundles.Add(new StyleBundle("~/AdminLTE/plugins/ionicons/cssboot").Include(
                                        "~/AdminLTE/plugins/ionicons/css/ionicons.min.css"));

            // plugins | ionslider
            bundles.Add(new Bundle("~/AdminLTE/plugins/ionslider/jsboot").Include(
                                         "~/AdminLTE/plugins/ionslider/js/ion.rangeSlider.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/ionslider/cssboot").Include(
                                        "~/AdminLTE/plugins/ionslider/css/ion.rangeSlider.css",
                                        "~/AdminLTE/plugins/ionslider/css/ion.rangeSlider.skinNice.css"));

            // plugins | jquery
            bundles.Add(new Bundle("~/AdminLTE/plugins/jquery/jsboot").Include(
                                         "~/AdminLTE/plugins/jquery/js/jQuery-2.1.4.min.js"));

            // plugins | jquery-validate
            bundles.Add(new Bundle("~/AdminLTE/plugins/jquery-validate/jsboot").Include(
                                         "~/AdminLTE/plugins/jquery-validate/js/jquery.validate*"));

            // plugins | jquery-ui
            bundles.Add(new Bundle("~/AdminLTE/plugins/jquery-ui/jsboot").Include(
                                         "~/AdminLTE/plugins/jquery-ui/js/jquery-ui.min.js"));

            // plugins | jvectormap
            bundles.Add(new Bundle("~/AdminLTE/plugins/jvectormap/jsboot").Include(
                                         "~/AdminLTE/plugins/jvectormap/js/jquery-jvectormap-1.2.2.min.js",
                                         "~/AdminLTE/plugins/jvectormap/js/jquery-jvectormap-world-mill-en.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/jvectormap/cssboot").Include(
                                        "~/AdminLTE/plugins/jvectormap/css/jquery-jvectormap-1.2.2.css"));

            // plugins | knob
            bundles.Add(new Bundle("~/AdminLTE/plugins/knob/jsboot").Include(
                                         "~/AdminLTE/plugins/knob/js/jquery.knob.js"));

            // plugins | morris
            bundles.Add(new StyleBundle("~/AdminLTE/plugins/morris/cssboot").Include(
                                        "~/AdminLTE/plugins/morris/css/morris.css"));

            // plugins | momentjs
            bundles.Add(new Bundle("~/AdminLTE/plugins/momentjs/jsboot").Include(
                                         "~/AdminLTE/plugins/momentjs/js/moment.min.js"));

            // plugins | pace
            bundles.Add(new Bundle("~/AdminLTE/plugins/pace/jsboot").Include(
                                         "~/AdminLTE/plugins/pace/js/pace.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/pace/cssboot").Include(
                                        "~/AdminLTE/plugins/pace/css/pace.min.css"));

            // plugins | slimscroll
            bundles.Add(new Bundle("~/AdminLTE/plugins/slimscroll/jsboot").Include(
                                         "~/AdminLTE/plugins/slimscroll/js/jquery.slimscroll.min.js"));

            // plugins | sparkline
            bundles.Add(new Bundle("~/AdminLTE/plugins/sparkline/jsboot").Include(
                                         "~/AdminLTE/plugins/sparkline/js/jquery.sparkline.min.js"));

            // plugins | timepicker
            bundles.Add(new Bundle("~/AdminLTE/plugins/timepicker/jsboot").Include(
                                         "~/AdminLTE/plugins/timepicker/js/bootstrap-timepicker.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/timepicker/cssboot").Include(
                                        "~/AdminLTE/plugins/timepicker/css/bootstrap-timepicker.min.css"));

            // plugins | raphael
            bundles.Add(new Bundle("~/AdminLTE/plugins/raphael/jsboot").Include(
                                         "~/AdminLTE/plugins/raphael/js/raphael-min.js"));

            // plugins | select2
            bundles.Add(new Bundle("~/AdminLTE/plugins/select2/jsboot").Include(
                                         "~/AdminLTE/plugins/select2/js/select2.full.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/select2/cssboot").Include(
                                        "~/AdminLTE/plugins/select2/css/select2.min.css"));

            // plugins | morris
            bundles.Add(new Bundle("~/AdminLTE/plugins/morris/jsboot").Include(
                                         "~/AdminLTE/plugins/morris/js/morris.min.js"));

        }
    }
}
