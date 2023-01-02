## Paramétrage de Git Bash

Dans le terminal Windows
- Définir un nom d'utilisateur : `git config --global user.name "Nom d'utilisateur"`
- Définir une adresse mail : `git config --global user.email adressemail@boitemail.fr`
- Définir la branche par défaut :  `git config --global init.defaultBranch main`
- Définir la méthode de "push" par défaut : `git config --global push.default current`

## Ajouter une fonctionnalité

1. Obtenir le code source du GitHub

   `git pull origin main`
2. Créer une branche avec `git checkout -b { nom de la branche }`

3. Pour chaque modification :
   1. Lister les modifications apportées avec `git status`
   2. Ajouter les documents modifiés avec `git add .`
   3. Donner un libellé à l'ensemble des modifications avec `git commit -m "Description de la modification"`
   4. Mettre en ligne ses modifications avec `git push`

4. Revenir sur la branche principale `main` avec `git checkout main`


## Après avoir fini de créer une fonctionnalité

Quand tous les éléments d'une fonctionnalité ont été apportés :

1. Aller sur la page GitHub du projet
2. Aller dans l'onglet `Pull requests`
3. Changer la valeur `compare:` pour sélectionner la branche de la fonctionnalité
4. Cliquer sur `Create pull request`
5. Valider avec sélectionnant `Create pull request`