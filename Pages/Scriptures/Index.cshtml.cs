using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchBookString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchThoughtString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortColumn { get; set; }
        public string SortOrder { get; set; }


        public async Task OnGetAsync()
        {

            var scriptures = from s in _context.Scripture select s;

            if (!string.IsNullOrEmpty(SearchBookString))
            {
                scriptures = scriptures.Where(s => s.Book.Contains(SearchBookString));
            } 
            else if (!string.IsNullOrEmpty(SearchThoughtString))
            {
                scriptures = scriptures.Where(s => s.Thoughts.Contains(SearchThoughtString));
            }
            else if (!string.IsNullOrEmpty(SortColumn))
            {
                switch (SortColumn) {
                    case "BookDown":
                        scriptures = scriptures.OrderBy(s => s.Book);
                        break;
                    case "BookUp":
                        scriptures = scriptures.OrderByDescending(s => s.Book);
                        break;
                    case "EntryDateDown":
                        scriptures = scriptures.OrderBy(s => s.EntryDate);
                        break;
                    case "EntryDateUp":
                        scriptures = scriptures.OrderByDescending(s => s.EntryDate);
                        break;
                    default:
                        scriptures = scriptures.OrderBy(s => s.ID);
                        break;
                }
            }

            Scripture = await scriptures.ToListAsync(); 
        }
    }
}
