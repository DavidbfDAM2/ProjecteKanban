# Projecte Kanban

Projecte intermodular de 2n de DAM per desenvolupar una aplicació de gestió de tasques amb un tauler Kanban.

## Equip

- David Baños Fàbregas
- Isaac Martinez Boada
- Ivan Pérez López

Tots tres participem en l’anàlisi, el disseny, la implementació, les proves i la documentació.

## Tecnologies previstes

- **C# i WPF amb Visual Studio:** aplicació d’escriptori per a Windows.
- **Fitxers locals:** persistència inicial de les dades.
- **MySQL i API:** l’esquema inicial de MySQL ja està definit. Més endavant, l’aplicació accedirà a la base de dades mitjançant una API.
- **Obsidian, Markdown i CSS:** documentació i exportació a PDF.
- **Jira:** planificació i seguiment amb sprints de dues setmanes.
- **Git i GitHub:** control de versions i treball en equip.

## Estat actual

Ja tenim les classes bàsiques del model (`Projecte`, `Columna`, `Tasca` i `Usuari`) i una primera vista del tauler en WPF. La vista mostra les columnes `ToDo`, `Doing` i `Done`, amb una targeta de prova a `ToDo`. De moment, el contingut és estàtic i els botons **+** encara no permeten crear tasques.

El pas següent és connectar la vista amb el model: mostrar una `Tasca` creada en memòria a la columna que correspon al seu `IdColumna`. Després hi afegirem la creació i el moviment de targetes i la persistència local de les dades. L’esquema MySQL ja està definit, però encara no està connectat a l’aplicació.

## Com obrir el projecte

Obriu [`ProjecteKanban.slnx`](src/app/ProjecteKanban/ProjecteKanban.slnx) amb Visual Studio a Windows. El projecte WPF està configurat per a **.NET Framework 4.7.2**.

## Estructura del projecte

```text
ProjecteKanban/
├── .obsidian/
│   ├── plugins/
│   │   └── memoria-pdf-css/           # Plugin d’exportació a PDF
│   │       ├── main.js
│   │       ├── manifest.json
│   │       ├── paged.js
│   │       └── PAGED-LICENSE.md
│   │
│   └── community-plugins.json
├── documentacio/
│   ├── imatges/
│   │   └── 1rEsborrany.png            # Prototip visual del tauler
│   │
│   ├── memoria-pdf.css
│   └── Sprint1.md
│
├── src/
│   ├── app/
│   │   └── ProjecteKanban/
│   │       ├── ProjecteKanban.slnx    # Solució de Visual Studio
│   │       └── ProjecteKanban/
│   │           ├── Classes/
│   │           │   ├── Columna.cs
│   │           │   ├── Projecte.cs
│   │           │   ├── Tasca.cs
│   │           │   └── Usuari.cs
│   │           │
│   │           ├── Properties/
│   │           │   ├── AssemblyInfo.cs
│   │           │   ├── Resources.Designer.cs
│   │           │   ├── Resources.resx
│   │           │   ├── Settings.Designer.cs
│   │           │   └── Settings.settings
│   │           │
│   │           ├── Views/
│   │           │   ├── TaulerView.xaml      # Primera vista del tauler
│   │           │   └── TaulerView.xaml.cs
│   │           │
│   │           ├── App.config
│   │           ├── App.xaml
│   │           ├── App.xaml.cs
│   │           ├── MainWindow.xaml        # Finestra que carrega TaulerView
│   │           ├── MainWindow.xaml.cs
│   │           └── ProjecteKanban.csproj
│   └── database/
│       ├── kanban.mwb                 # Model de MySQL Workbench
│       └── schema.sql                 # Script de creació de la base de dades
├── .gitignore
└── README.md
```

Es mostra la part destinada a compartir-se amb Git.
Les configuracions personals d’Obsidian queden ignorades.

## Documentació

Ja es poden consultar:

- [Informe del Sprint 1](documentacio/Sprint1.md): planificació, repartiment de tasques i disseny inicial.
- [Prototip visual del tauler](documentacio/imatges/1rEsborrany.png): primer esborrany de la interfície.

A mesura que avanci el projecte, hi afegirem l’anàlisi de requisits, els diagrames de classes i de dades, els informes dels sprints següents i els manuals d’usuari i d’instal·lació. Els documents de lliurament s’exportaran a PDF.

## Organització

Equip de tres persones, amb metodologia Scrum i seguiment a Jira.
Les proves i la documentació s’actualitzaran durant cada sprint.

## Planificació i seguiment

Gestió del Product Backlog i els sprints: 
- [Jira - ProjecteKanban](https://daviddam2.atlassian.net/jira/software/projects/KBAN/boards/34/backlog).
L’accés requereix iniciar sessió amb un compte autoritzat.