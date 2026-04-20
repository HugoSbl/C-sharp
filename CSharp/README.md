Suite à réinitialisation de mon mac, j'ai perdu les anciens projets qui étaient dans le dossier rider plutot que dans mon dossier de dev, qui lui était save. 

### organisation du code
Deux version des Controller, un opti et un pas opti. 

En lancant le programme on a directement le timer qui différencie la version opti et non opti. Les deux s'executent une fois avec ce qu'il y a dans le dossier ImagesTest. 
Il faudra juste changer la variable filePath dans le Program.cs en fonction de l'environnement.


Division par deux du temps nécéssaire pour traiter deux images. Voici les logs associés à une RUN : 
```
/Users/hugo/RiderProjects/CSharp/CSharp/bin/Debug/net10.0/CSharp
Récupération des images de /Users/hugo/RiderProjects/CSharp/CSharp/ImagesTest
Nombre d'images trouvées : 2
Version non opti
Image : tableau de suivi H Sablot, Path : /Users/hugo/RiderProjects/CSharp/CSharp/ImagesTest/tableau de suivi H Sablot.png
Image tableau de suivi H Sablot convertie.
Image : My Cool Bike, Path : /Users/hugo/RiderProjects/CSharp/CSharp/ImagesTest/My Cool Bike.png
Image My Cool Bike convertie.
VERSION NON OPTI : 3161 ms.
Démarrage version optimisée
Image : tableau de suivi H Sablot, Path : /Users/hugo/RiderProjects/CSharp/CSharp/ImagesTest/tableau de suivi H Sablot.png
Image : My Cool Bike, Path : /Users/hugo/RiderProjects/CSharp/CSharp/ImagesTest/My Cool Bike.png
VERSION OPTI : 1541 ms.
```

Donc version opti : 1541 ms
Version non opti : 3161 ms