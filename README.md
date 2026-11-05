# Calculatrice

Calculatrice de bureau en C# / Windows Forms (.NET 10).

## Fonctionnalités

- Addition, soustraction, multiplication et division
- Enchaînement des calculs : `2 + 3 × 4` calcule au fur et à mesure
- Nombres à virgule, avec le séparateur décimal de Windows
- Historique du calcul en cours au-dessus du résultat
- Message clair en cas de division par zéro
- Bouton `←` pour effacer le dernier chiffre, `C` pour tout remettre à zéro
- Utilisable au clavier

| Touche | Action |
|---|---|
| `0` à `9` | Chiffres |
| `,` ou `.` | Virgule |
| `+` `-` `*` `/` | Opérations |
| `Entrée` ou `=` | Résultat |
| `Retour arrière` | Effacer le dernier chiffre |
| `Échap` ou `Suppr` | Tout effacer |

## Organisation du code

- `Calculateur.cs` : la logique de calcul, indépendante de l'interface
- `Form1.cs` : relie les boutons et le clavier au calculateur
- `Form1.Designer.cs` : l'interface, une grille qui s'adapte à la taille de la fenêtre

## Lancer le projet

Prérequis : Windows et le [SDK .NET 10](https://dotnet.microsoft.com/download).

```bash
dotnet run --project Calculatrice/Calculatrice/Calculatrice.csproj
```

Ou ouvrir `Calculatrice/Calculatrice.slnx` dans Visual Studio et appuyer sur F5.
