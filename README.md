# Boutique Diayma
## 2. Structure du projet

La solution contient **un seul projet** nommé :

- **P2FixAnAppDotNetCode**
    

Ce projet contient tout le code de l’application web ASP.NET Core, incluant :

- les contrôleurs (`Controllers/`),
    
- les vues (`Views/`),
    
- les composants (`Components/`),
    
- les modèles (`Models/`),
    
- les ressources statiques (`wwwroot/`).
    

---

## 3. Version du SDK .NET utilisée

Le projet cible `.NET Core 2.0` avec le SDK suivant :

`<Project Sdk="Microsoft.NET.Sdk.Web">   <PropertyGroup>     <TargetFramework>netcoreapp2.0</TargetFramework>   </PropertyGroup>   ... </Project>`

Détails :

- Target Framework : `.NET Core 2.0` (`netcoreapp2.0`)
    
- SDK : `Microsoft.NET.Sdk.Web` (spécialisé pour ASP.NET Core)
    
- Packages utilisés : `Microsoft.AspNetCore.All 2.0.6` et autres compatibles avec .NET Core 2.0.
    

---

## 4. Installation du SDK

Sur ma machine, la commande :

`dotnet --version`

retourne la version `10.0.100-rc.1.25451.107` (release candidate récente du SDK .NET) compatible avec les projets ciblant `.NET Core 2.0`.

---

## 5. Dépôt GitHub

Le projet est disponible sur GitHub :  
[https://github.com/Tening2283/BoutiqueDiayma2025](https://github.com/Tening2283/BoutiqueDiayma2025)

---

## 6. Bugs rencontrés

1. Le stock des produits ne diminue pas lorsque l’utilisateur ajoute un article au panier, ce qui peut induire en erreur sur la disponibilité réelle.
    
2. La sélection de la langue espagnole dans le menu ne fonctionne pas : l’interface reste en français.
    

---

## 8. Flux d’exécution pour l’affichage des produits

- **Namespace principal** : `P2FixAnAppDotNetCode.Controllers`
    
- **Classe principale** : `ProductController`
    
- **Méthode** : `Index()` (ligne 20 dans `ProductController.cs`)
    
- **Route par défaut** : `/` → appelle `ProductController.Index()`.
    

### Étapes :

1. `Startup.Configure` configure la localisation, la session, le routage (`{controller=Product}/{action=Index}/{id?}`).
    
2. `ProductController.Index()` récupère la liste des produits via `_productService.GetAllProducts()`.
    
3. `ProductService.GetAllProducts()` interagit avec le repository pour obtenir les données.
    
4. La vue `Views/Product/Index.cshtml` est rendue avec la liste des produits.
    

---

## 9. Commande pour publier le projet

`dotnet publish -c Release -r win-x64 --self-contained true`

---

## 10. Lien Google Drive

Voici le lien vers les fichiers publiés et livrables :  
[https://drive.google.com/drive/folders/1mRfVQh30N_dVfy0DbX3gTucfcwDlj5QJ?usp=drive_link](https://drive.google.com/drive/folders/1mRfVQh30N_dVfy0DbX3gTucfcwDlj5QJ?usp=drive_link)

---

## 11. Modifications apportées (commits)

- Ajout de la langue Wolof dans l’interface.
    
- Ajout d’un bouton pour le mode sombre.
    
- Changement du background (arrière-plan).
