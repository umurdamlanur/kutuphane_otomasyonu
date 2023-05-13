create database kutuphane_otomasyonu
use kutuphane_otomasyonu
create table tbl_kayıt_ol(
id int,
ad nchar(50),
soyad nchar(50),
eposta nchar(50),
sıfre nchar(10)
)

use kutuphane_otomasyonu
create table tbl_kullanici_giris(
id int,
ad nchar(50),
sıfre nchar(10)
)

use kutuphane_otomasyonu
create table tbl_admin_giris(
id int,
ad nchar(50),
sıfre nchar(10)
)

insert into tbl_admin_giris(id, ad, sıfre)
values(1, 'damla', '1111'),
(2, 'admin', '12345')

insert into tbl_kullanici_giris(id, ad, sıfre)
values(1, 'damla', '1111')

use kutuphane_otomasyonu
create table tbl_kitap_bilgileri(
kod int,
k_ad varchar(100),
yazar_ad varchar(100),
sayfa_sayisi int,
yayinevi_ad varchar(100),
yayin_tarihi date,
konusu varchar(150)
)

use kutuphane_otomasyonu
create table tbl_alınan_kitap(
kod int,
k_ad varchar(100),
yazar_ad varchar(100),
sayfa_sayisi int,
alinan_tarih date,
teslim_tarihi date,
teslim_alan varchar(100)
)

select * from tbl_kullanici_giris
select * from tbl_admin_giris
select * from tbl_kayıt_ol
select * from tbl_kitap_bilgileri

use kutuphane_otomasyonu
create table tbl_kitapp(
kod int,
k_ad varchar(100),
yazar_ad varchar(100),
sayfa_sayisi int,
yayinevi_ad varchar(100),
yayin_tarihi date,
konusu varchar(150),
alinan_tarih date,
teslim_tarihi date,
teslim_alan varchar(100)
)
select * from tbl_kitapp
