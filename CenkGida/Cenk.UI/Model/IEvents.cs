using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenk.UI.Model
{
    interface IEvents
    {
        void RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e);

        void NavigationItemClick(object sender, DevExpress.XtraBars.Navigation.NavigationBarItemEventArgs e);
        void GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e);

        void btnNewClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        void btnDetailsClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        void btnEditClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        void btnRefreshClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        void btnDeleteClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);


        void btnPreviewClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        void btnPrintClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        void btnExcelClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        void btnPDFClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
    }
}
