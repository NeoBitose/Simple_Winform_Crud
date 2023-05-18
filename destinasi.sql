CREATE TABLE IF NOT EXISTS tujuan.destinasi(
	id_destinasi serial NOT NULL,
	nama_destinasi character varying NOT NULL,
	deskripsi_wisata text COLLATE pg_catalog."default" NOT NULL,
	provinsi character varying NOT NULL,
	kota character varying NOT NULL,
	kecamatan character varying NOT NULL,
	nama_jalan text COLLATE pg_catalog."default" NOT NULL,
	tarif_harga integer NOT NULL,
	luas_wilayah character varying NOT NULL,
	CONSTRAINT destinasi_pk PRIMARY KEY (id_destinasi)
);

insert into tujuan.destinasi (nama_destinasi, deskripsi_wisata, provinsi, kota, kecamatan, nama_jalan, tarif_harga, luas_wilayah) 
values ('Papuma', 'Wisata pantai', 'jawa timur', 'jember', 'Ambulu', 'Jln raya papuma', '25000', '1040m');

insert into tujuan.destinasi (nama_destinasi, deskripsi_wisata, provinsi, kota, kecamatan, nama_jalan, tarif_harga, luas_wilayah) 
values ('Kawah Ijen', 'Wisata gunung', 'jawa timur', 'bondowoso', 'Ijen', 'Jln raya ijen', '15000', '2040m');

insert into tujuan.destinasi (nama_destinasi, deskripsi_wisata, provinsi, kota, kecamatan, nama_jalan, tarif_harga, luas_wilayah) 
values ('Air Terjun Tancak kembar', 'Wisata air terjun', 'jawa timur', 'bondowoso', 'Curahdami', 'Jln raya curahdami', '8000', '340m');

insert into tujuan.destinasi (nama_destinasi, deskripsi_wisata, provinsi, kota, kecamatan, nama_jalan, tarif_harga, luas_wilayah) 
values ('Kawah Wurung', 'Wisata bukit', 'jawa timur', 'Bondowoso', 'Ijen', 'Jln raya ijen', '10000', '2040m');

insert into tujuan.destinasi (nama_destinasi, deskripsi_wisata, provinsi, kota, kecamatan, nama_jalan, tarif_harga, luas_wilayah) 
values ('Sungai Bedadung', 'Wisata sungai', 'jawa timur', 'jember', 'jember', 'Jln patrang', '5000', '150m');

-- select * from tujuan.destinasi;

-- TRUNCATE tujuan.destinasi RESTART IDENTITY;
