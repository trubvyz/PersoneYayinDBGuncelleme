﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationParse
{
    public class User
    {
        public int? PersonId { get; set; }
        public string TcNumarasi { get; set; }
        public string Uyruk { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Cinsiyeti { get; set; }
        public string Eposta { get; set; }
        public string TelefonCep { get; set; }
        public string TelefonDahili { get; set; }
        public string TelefonDahiliNumara { get; set; }
        public string Adres { get; set; }
        public string BabaAdi { get; set; }
        public string AnaAdi { get; set; }
        public string DogumYeri { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string KanGrubu { get; set; }
        public string SehitGaziYakini { get; set; }
        public string Asili { get; set; }
        public string CovidBagisik { get; set; }
        public string SonTestZamani { get; set; }
        public string HesDurumu { get; set; }
        public int? PersonelTipiId { get; set; }
        public string PersonelTipi { get; set; }
        public int? GorevYeriId { get; set; }
        public string GorevYeri { get; set; }
        public DateTime? GoreveBaslamaTarihi { get; set; }
        public string KurumdanAyrilisTarihi { get; set; }
        public int? KadroTipiId { get; set; }
        public string KadroTipi { get; set; }
        public string KadroKodu { get; set; }
        public string IdariGorevler { get; set; }
        public string IliskiliOlduguPozisyonlar { get; set; }
        public string EmekliSicilKodu { get; set; }
        public string UnvanId { get; set; }
        public string AsliUnvan { get; set; }
        public int? EkGosterge { get; set; }
        public int? GorevUnvaniId { get; set; }
        public string GorevUnvan { get; set; }
        public int? KadroUnvanId { get; set; }
        public string KadroUnvan { get; set; }
        public string KurumSicilNo { get; set; }
        public int? UstGorevYeriId { get; set; }
        public string UstGorevYeriAdi { get; set; }
        public string PersonBase64Image { get; set; }
        public int? UstGorevBirimId { get; set; }
        public string UstGorevBirimAdi { get; set; }
        public int? KadroBirimId { get; set; }
        public string KadroBirimi { get; set; }
        public int? KadroUstBirimId { get; set; }
        public string KadroUstBirim { get; set; }
        public bool? Aktif { get; set; }
        public string Username { get; set; }
        public string PersonEncryptedId { get; set; }
        public string PersonBase64ImageModifiedOn { get; set; }
        public string BrutUcret { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }
        public string KisiselEPosta { get; set; }
        public string KisiselTelefon { get; set; }
    }

    public class UserInfo
    {
        [Key]
        public int Id { get; set; }

        public int AuthorId { get; set; }

        public int PersonId { get; set; }

        public string? Title { get; set; }

        public string? KadroUnvan { get; set; }

        public string? Faculty { get; set; }

        public string? Department { get; set; }

        public string? MSB { get; set; }
    }
}
