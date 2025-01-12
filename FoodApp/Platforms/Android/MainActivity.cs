using Android.App;
using Android.Content.PM;
using Android.OS;

namespace FoodApp;

/*
 * Άσκηση 6.8:
Δημιουργήστε ένα mobile application με .NET MAUI. Το συγκεκριμένο application να είναι ένα port της εφαρμογής φαγητού που τροποποιήσατε για την άσκηση 3.8
Δεν χρειάζεται να υπάρχει “Έξοδος” από την εφαρμογή
Δεν χρειάζεται να εισάγει κείμενο ο χρήστης
Το μενού πρέπει να εμφανίζεται με collection view, στο οποίο ο χρήστης θα επιλέγει από τη λίστα ποιο φαγητό θέλει να παραγγείλει
Πρέπει να υπάρχει ένα κουμπί “Cancel” το οποίο θα ακυρώνει την προετοιμασία φαγητού, όταν το φαγητό ετοιμάζεται. Το κουμπί πρέπει να κρύβεται όταν δεν υπάρχει φαγητό
που προετοιμάζεται
Τα μηνύματα που θα εμφανίζονται στον χρήστη να είναι τα ίδια που εμφανίζονται στο console application, απλά 
τώρα θα πρέπει να εμφανίζονται σε ένα Label κάτω από το collection view
 */
[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode |
                           ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
}