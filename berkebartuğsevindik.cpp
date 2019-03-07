#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#define MAX_MUSTERI 20
								//Berke Bartuð Sevindik 2015280028 && Ahmet Buðra Moðol ile birlikte çalýþtýk.
typedef struct Musteri{
int gelis_zamani;
int servis_suresi;
int bekleme_suresi;
int cikis_zamani;
}kayit;
struct Dugum{
 	Musteri kayit;
	Dugum *sonraki;
}; 
struct Kuyruk{	
	Dugum * bas;
	Dugum * son;	
	void olustur();
	void kapat();
	void ekle(Musteri);
	Musteri cikar();
	bool bosmu();
};


void Kuyruk::olustur(){
	bas=NULL;son=NULL;
}
void Kuyruk::kapat(){
	Dugum *p;
	while (bas){
		p = bas;
		bas = bas->sonraki;
		delete p;
	}
}
void Kuyruk::ekle(Musteri yeni){
	Dugum *yenidugum=new Dugum;
	yenidugum->kayit=yeni;
	yenidugum->sonraki=NULL;
	if(bas==NULL){
		bas=yenidugum;
		bas->sonraki=son;  }
	else{   son=yenidugum;
		son->sonraki=NULL;}
}
Musteri Kuyruk::cikar(){
	Dugum *ustdugum;
	Musteri gecici;
	ustdugum=bas;
	bas=bas->sonraki;
	gecici=ustdugum->kayit;	
	delete ustdugum;
	return gecici;
}
bool Kuyruk::bosmu(){
	return bas==NULL;
}
int k=0;
void baslat(Musteri kayit[],int m_sayi)
{
int gelis_zamani=0;
for(int i=0;i<m_sayi;i++)
{ 
	kayit[i].gelis_zamani=k+int(rand()%3);  //geliþ zamanný bir öncekinden 1-2-3 arasýnda bir random sayýyla gelicek
    kayit[i].servis_suresi=int(1+rand()%5);//1-5 dk arasinda
   
    k=k+3; //k yý her seferinde 3 arttýrdým böylece sonra gelen öncekinin süresinden önce gelme gibi saçma biþi olmuyacak
   }
  
getchar();
}
void servis_baslat(Kuyruk k,Musteri kayit[],int m_sayi)
{

int i=0;
int cikis_zamani=0;
while(i<m_sayi){
k.ekle(kayit[i]);
																//tek çalýsan olarak verebildim.
if(kayit[i].gelis_zamani<cikis_zamani)
     {kayit[i].bekleme_suresi=cikis_zamani-kayit[i].gelis_zamani;
      kayit[i].cikis_zamani=cikis_zamani+kayit[i].servis_suresi;
     k.cikar();
      }
else
     {kayit[i].bekleme_suresi=0;
      kayit[i].cikis_zamani=kayit[i].gelis_zamani+kayit[i].servis_suresi;
      k.cikar();
       }
cikis_zamani=kayit[i].cikis_zamani;
i++;
}

}
void calisan_performans(Musteri kayit[],int m_sayi)
{
int top_bos_sure=0;
int top_bekletme=0;
int cikis_zamani=0;
int x,i=0;
	FILE *fp;
	fp = fopen("dosya.txt","w");
while(i<m_sayi)
{
if(kayit[i].gelis_zamani>cikis_zamani)
top_bos_sure=top_bos_sure+kayit[i].gelis_zamani-cikis_zamani;
top_bekletme=top_bekletme+kayit[i].bekleme_suresi;
cikis_zamani=kayit[i].cikis_zamani;
i++;
}
printf("\nCalisanlarin bosta kalma suresi:%d dk.\n",top_bos_sure);
printf("Bankamizin musterileri bekletme suresi: %d dk.\n",top_bekletme);

}
void sonuc_yazdir(Kuyruk k,Musteri kayit[],int m_sayi){
	printf("Musteri no:\tGelis zamani:\tBekleme suresi:\tServis suresi:\tCikis zamani :\n");
	printf("-----------\t-------------\t---------------\t--------------\t--------------\n");
    for(int i=0;i<m_sayi;i++)
	printf("%d\t\t%d\t\t%d\t\t%d\t\t%d\n",i+1,kayit[i].gelis_zamani,kayit[i].bekleme_suresi,kayit[i].servis_suresi,kayit[i].cikis_zamani);

}

int main(){

     struct Musteri kayit[MAX_MUSTERI];
     Kuyruk k;
     int i,m_sayi;
     k.olustur();
     printf("Toplam musteri sayisini giriniz\n");
     scanf("%d",&m_sayi);
	baslat(kayit,m_sayi);
	servis_baslat(k,kayit,m_sayi);
	sonuc_yazdir(k,kayit,m_sayi);
	calisan_performans(kayit,m_sayi);
	FILE *fp;
	fp = fopen("gunsonu.txt","w");
	for(i=0;i<m_sayi;i++)
	{
			fprintf(fp,"%d\t\t%d\t\t%d\t\t%d\t\t%d\n",i+1,kayit[i].gelis_zamani,kayit[i].bekleme_suresi,kayit[i].servis_suresi,kayit[i].cikis_zamani);
			
	}
		

     return EXIT_SUCCESS;
}

