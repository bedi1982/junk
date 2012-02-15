#include <stdlib.h>
#include <stdio.h>
#include <unistd.h>
#include <sys/types.h>
#include <string.h>

void testiculo()
{
	printf ("\nYou are currently using the locale:\n");
	system ("echo `echo $LANGUAGE | cut -d: -f1`\n");
}

int wich_locales_remove()
{
	int choose;

	printf ("\nWich locales you want to remove?\n");
	printf (" 1 - Firefox ones\n");
	printf (" 2 - Thunderbird ones\n");
	printf (" 3 - KDE ones\n");
	printf (" 4 - Firefox + Thunderbird + KDE locales\n");
	printf (" 5 - Exit\n");

	scanf ("%d", &choose);
	if ( choose <= 5){
		return choose;
	}else{
		printf ("Invalid Number\n");
		return 6; //will print the menu again
	}
}

char* in_use_locale(char *locale)
{	
	strcpy (locale, getenv("LANGUAGE")); //gets the system/user locale
	locale = strtok(locale," : . "); //use only the part before : or .

	if (strcmp(locale, "en_US" ) == 0 ){ //verify if system locale is en_US, if yes, use the packaged name:
		strcpy(locale,"en_GB"); //copies "en_GB to locale"
	}
	return locale;
}

void kde_locales()
{
	char locale[10];
	char com[100];
	char procede;

	in_use_locale(locale); //get currently used locale from in_use_locale() function

	system ("rpm -qa |grep l10n|grep kde> /tmp/installed_locales");
	system ("cat /tmp/installed_locales |grep -v \"kde-l10n-en_US*\" > /tmp/unused_locales");
	sprintf (com,"cat /tmp/unused_locales |grep -v \"kde-l10n-%s-*\" > /tmp/unused_locales2",locale);
	system (com);

	printf ("You want to proceed?(y/n)\n");
	scanf (" %c", &procede);
	if ( procede=='Y' || procede=='y' ){
		system ("urpme `cat /tmp/unused_locales2`");
	}else{
		printf ("Cagão :)\n");
		system ("rm -f /tmp/unused_locales*");
		system ("rm -f /tmp/installed_locales*");
	}

	printf ("Remaining installed KDE locales are:\n");
	system ("rpm -qa |grep l10n|grep kde");

}

void firefox()
{
	char locale[10];
	char comando[100];
	char procede;
	
	in_use_locale(locale); //get currently used locale from in_use_locale() function

	system ("rpm -qa |grep firefox |grep -v \"firefox-6-*\" > /tmp/firefox_locales_installed");
	system ("cat /tmp/firefox_locales_installed |grep -v \"firefox-en_GB\" > /tmp/firefox_locales_unused");
	system ("cat /tmp/firefox_locales_unused |grep -v \"firefox-ext\" > /tmp/firefox_locales_unused2");

	sprintf (comando, "cat /tmp/firefox_locales_unused2 |grep -v \"firefox-%s\" > /tmp/firefox_locales_unused3",locale);
	system (comando);

	printf ("You want to proceed?(y/n)\n");
	scanf (" %c", &procede);

	if ( procede=='Y' || procede=='y' ){
		system ("urpme `cat /tmp/firefox_locales_unused3`");
	}else{
		printf ("Cagão :)\n");
		system("cat /tmp/firefox_locales_unused3");
		system ("rm -f /tmp/firefox_locales*");
	}
	printf ("Remaining installed Firefox packages are:\n");
	system ("rpm -qa |grep firefox");

}

void thunderbird()
{
	char locale[10];
	char comando[100];
	char procede;

	in_use_locale(locale); //get currently used locale from in_use_locale() function

	system ("rpm -qa |grep thunderbird |grep -v \"mozilla-thunderbird-6.0*\" > /tmp/tb_locales_installed");
	system ("cat /tmp/tb_locales_installed |grep -v \"mozilla-thunderbird-en_GB\" > /tmp/tb_locales_unused");
	system ("cat /tmp/tb_locales_unused |grep -v \"firefox-ext\" > /tmp/tb_locales_unused2");

	sprintf (comando, "cat /tmp/tb_locales_unused2 |grep -v \"mozilla-thunderbird-%s\" > /tmp/tb_locales_unused3",locale);
	system (comando);

	printf ("You want to proceed?(y/n)\n");
	scanf (" %c", &procede);
	if ( procede=='Y' || procede=='y' ){
		system ("urpme `cat /tmp/tb_locales_unused3`");
	}else{
		printf ("Cagão :)\n");
		system("cat /tmp/tb_locales_unused3");
		system ("rm -f /tmp/tb_locales*");
	}
	printf ("Remaining installed Thunderbird packages are:\n");
	system ("rpm -qa |grep thunderbird");
}

void main()
{
	int choose;

	if(geteuid() != 0){
		printf("Run as root\n");
	}else{
		testiculo(); //Print a intro text
		choose = wich_locales_remove(); //Call wich_locales_remove() function
		switch (choose){
			case 1: firefox(); break;
			case 2: thunderbird(); break;
			case 3: kde_locales(); break;
			case 4: system("clear"); printf("not added yet - All others are working :)\n"); main(); break;
			case 5: printf("bye bye\n"); break;
			default: main(); break;
		}

	}
}
