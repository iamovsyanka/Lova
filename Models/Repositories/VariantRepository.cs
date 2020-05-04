using Microsoft.EntityFrameworkCore;
using Models.Models;
using Models.Contexts;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public class VariantRepository : IVariantRepository
    {
        private LovaContext context;
        public VariantRepository(LovaContext context)
        {
            this.context = context;
        }

        public IQueryable<Variant> Get() => context.Variants;

        public async Task AddAsync(Variant variant)
        {
            if (variant == null)
            {
                throw new ArgumentException();
            }

            await context.Variants.AddAsync(variant);
            await context.SaveChangesAsync();
        }

        public async Task RemoveAsync(int variantId)
        {
            var variantToRemove = await Get().FirstOrDefaultAsync(v => v.VariantId == variantId);

            if(variantToRemove != null)
            {
                context.Variants.Remove(variantToRemove);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(int variantId, Variant newVariant)
        {
            var variantToChange = await Get().FirstOrDefaultAsync(v => v.VariantId == variantId);

            if(variantToChange != null)
            {
                variantToChange.Description = newVariant.Description;
                variantToChange.IsTrue = newVariant.IsTrue;

                await context.SaveChangesAsync();
            }
        }
    }
}
