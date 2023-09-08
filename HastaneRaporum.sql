--Yaþý 30 dan büyük olanlarýn yaþ ortalamasý

alter proc yasOtuzOrt
as begin
select avg(yas) from hastalar
where yas>30
end

alter proc yasOtuzBoyOrt
as begin
select avg(boy) from hastalar
where yas>30
end


alter proc boyYüzatmisYasOrt
as begin
select avg(yas) from hastalar
where boy>160
end

create proc sonKayitYüzdeBes
as begin
select top 5 percent * from hastalar
end

create proc yasGrupTersSira
as begin
select yas from hastalar
group by yas
order by yas desc
end


create proc PolHastDoktor
as begin
select p.polIsim,p.polCalisanAdi,h.adSoyad,h.yas,d.Adý,d.unvan,d.Maas
from poliklinikler p
inner join hastalar h
on p.hastaNo=h.hastaNo
inner join receteler r
on p.hastaNo=r.hastaNo
inner join doktorlar d
on r.doktorId=d.doktorId
end









--create proc isimPolUzmSayi
--as begin 
--select * from doktorlar

--end
select * from poliklinikler
alter table poliklinikler
add unvanSayisi nvarchar(50)


create proc polUzmSayi(
@polIsim nvarchar(50)
)
as begin
select polIsim,uzmanSayisi from poliklinikler
where polIsim=@polIsim
group by polIsim,uzmanSayisi
end

create proc polYatakSayi(
@polIsim nvarchar(50)
)
as begin
select polIsim,YatakSayisi from poliklinikler
where polIsim=@polIsim
group by polIsim,YatakSayisi
end

alter proc doktorAdGrup
as begin
select Adý from doktorlar
group by Adý
end


create proc unvanYas
(
@ünvan nvarchar(50)
)
as begin
select unvan,Yas from doktorlar
where unvan=@ünvan
group by unvan,Yas
end

create proc unvanMaas
(
@ünvan nvarchar(50)
)
as begin
select unvan,Maas from doktorlar
where unvan=@ünvan
group by unvan,Maas
end


create proc raporYasOrt(
@raporDurum nvarchar(50)
)
as begin
select RaporDurum,avg(yas) from hastalar
where RaporDurum=@raporDurum
group by RaporDurum
end





