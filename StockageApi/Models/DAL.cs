using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace StockageApi.Models
{
    public class DAL : IDAL
    {
        private DBContext Db;
        public DAL()
        {
            Db = new DBContext();
        }

        public async Task<bool> AddProduct(ProductModel Product)
        {
           if(Product != null)
            {
                Db.ProductModels.Add(Product);
               var response = await Db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public bool DeleteProduct(int ID)
        {
            var Product = Db.ProductModels.FirstOrDefault(model => model.Id == ID);
            if (Product != null)
            {
                Db.ProductModels.Remove(Product);
                Db.SaveChanges();
                return true;
            }
            return false;
        }

        public ProductModel GetProduct(int ID)
        {
            var Product = Db.ProductModels.FirstOrDefault(model => model.Id == ID);
            if (Product != null)
                return Product;
            return null;
        }

        public List<ProductModel> GetProducts()
        {
            List<ProductModel> ListProducts = Db.ProductModels.ToList<ProductModel>();
                return ListProducts;
        }


        #region IDisposable Support
        private bool disposedValue = false; // Pour détecter les appels redondants

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: supprimer l'état managé (objets managés).
                }

                // TODO: libérer les ressources non managées (objets non managés) et remplacer un finaliseur ci-dessous.
                // TODO: définir les champs de grande taille avec la valeur Null.

                disposedValue = true;
            }
        }

        // TODO: remplacer un finaliseur seulement si la fonction Dispose(bool disposing) ci-dessus a du code pour libérer les ressources non managées.
        // ~DAL()
        // {
        //   // Ne modifiez pas ce code. Placez le code de nettoyage dans Dispose(bool disposing) ci-dessus.
        //   Dispose(false);
        // }

        // Ce code est ajouté pour implémenter correctement le modèle supprimable.
        public void Dispose()
        {
            // Ne modifiez pas ce code. Placez le code de nettoyage dans Dispose(bool disposing) ci-dessus.
            Dispose(true);
            // TODO: supprimer les marques de commentaire pour la ligne suivante si le finaliseur est remplacé ci-dessus.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}