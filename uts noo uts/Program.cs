namespace uts_pbo
{
    public class Agen
    {
        public string idAgen;
        public string namaAgen;
        public int stokAgen;

        public Agen(string idagen, string namaagen, int stokagen)
        {
            this.idAgen = idagen;
            this.namaAgen = namaagen;
            this.stokAgen = stokagen;
        }

        public void TampilInfo()
        {
            Console.WriteLine($"{namaAgen} memiliki stok {stokAgen} galon");
        }

        abstract class ProdukGalon
        {
            private string idProduk { get; set; }
            private string namaProduk { get; set; }
            private int stokGudang { get; set; }

            public ProdukGalon(string idproduk, string namaproduk, int stokgudang)
            {
                this.idProduk = idproduk;
                this.namaProduk = namaproduk;
                this.stokGudang = stokgudang;
            }

            public void KurangiStok(int jumlah)
            {
                if (stokGudang > 0)
                {
                    return jumlah - stokGudang;

                } else
                {
                    Console.WriteLine("stok tidak mencukupi");
                }
            }

            public virtual void HitungBiaya(int jumlah)
            {
                return;
            }
        }

        abstract class GalonAkua : ProdukGalon
        {
            public ProdukGalon(string idproduk, string namaproduk, int stokgudang): base(idproduk,namaproduk, stokgudang)
            {

            }

            public override void HitungBiaya(int jumlah)
            {

            }
        }

        abstract class GalonBerkeran : ProdukGalon
        {
            public ProdukGalon(string idproduk, string namaproduk, int stokgudang) : base(idproduk, namaproduk, stokgudang)
            {

            }

            public override void HitungBiaya(int jumlah)
            {
                base.HitungBiaya(jumlah);
            }
        }

        public interface IDapatDidistribusikan
        {
            public void KirimPaket()
            {
                
            }
        }

        public class DistribusiGalon : IDapatDidistribusikan
        {
            public string Agen;
            public string ProdukGalon;
            public int jumlah;

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
