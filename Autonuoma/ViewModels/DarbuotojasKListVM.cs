using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Org.Ktu.Isk.P175B602.Autonuoma.ViewModels
{
	/// <summary>
	/// Model of 'Irenginys' entity used in lists.
	/// </summary>
	public class DarbuotojasKListVM
    {
        //id, dirbanuo, dirbaiki, darbuotojoRole, fk_ASMUOid
        [DisplayName("Id")]
        public int Id { get; set; }

        //dirba nuo
        [DisplayName("Dirba nuo")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime DirbaNuo { get; set; }

        //dirba iki
        [DisplayName("Dirba iki")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime DirbaIki { get; set; }

        //darbuotojo role
        [DisplayName("Darbuotojo role")]
        public string DarbuotojoRole { get; set; }

        [DisplayName("Pavarde")]
        public string Pavarde { get; set; }

        //fk_ASMUOid
        [DisplayName("Vardas")]
        public string FkASMUOid { get; set; }

    }
}