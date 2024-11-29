using CodeSnippetTool.Data;
using CodeSnippetTool.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSnippetTool.Controllers
{
    public class TranslationController
    {
        private readonly AppDbContext _context;

        public TranslationController(AppDbContext context)
        {
            _context = context;
        }

        // Method to create or update a translation
        public async Task SaveTranslationAsync(Translation translation, bool isNew)
        {
            if (isNew)
            {
                _context.Translations.Add(translation);  // Add the new translation
            }
            else
            {
                _context.Translations.Update(translation);  // Update the existing translation
            }

            await _context.SaveChangesAsync();  // Save changes to the database
        }

        // Method to review a translation (marks as reviewed and sets the date)
        public async Task ReviewTranslationAsync(int translationId, int currentUserId)
        {
            // Fetch the translation based on its Id
            var translation = await _context.Translations
                                            .FirstOrDefaultAsync(t => t.Id == translationId);

            if (translation == null)
            {
                throw new InvalidOperationException("Translation not found.");
            }

            // Mark as reviewed and set the reviewer information
            translation.Reviewed = true;
            translation.ReviewerId = (int)UserSession.CurrentUserId; 
            translation.ReviewDate = DateTime.Now;  

            // Update the translation record in the database
            _context.Translations.Update(translation);
            await _context.SaveChangesAsync();
        }

        // Method to fetch the translation and its review details
        public async Task<Translation> GetTranslationWithReviewAsync(int translationId)
        {
            // Fetch translation with its review information (if any)
            return await _context.Translations
                                  .Where(t => t.Id == translationId)
                                  .Select(t => new Translation
                                  {
                                      Id = t.Id,
                                      Language = t.Language,
                                      TranslationText = t.TranslationText,
                                      Reviewed = t.Reviewed,
                                      ReviewerId = t.ReviewerId,
                                      ReviewDate = t.ReviewDate
                                  })
                                  .FirstOrDefaultAsync();
        }
    }
}
