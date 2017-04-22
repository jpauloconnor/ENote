using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DumbSaint.Models
{
    public class NoteListItemModel
    {
        public int NoteId { get; set; }
        public string Title { get; set; }

        [Display(Name="Created")]
        public DateTimeOffset CreatedUTC { get; set; }

        public override string ToString() => Title;
    }
}
