# Projecte Kanban

Projecte intermodular de 2n de DAM per desenvolupar una aplicació de gestió de tasques amb un tauler Kanban.

## Equip

- David Baños Fàbregas.
- Isaac Martinez Boada.
- Ivan Pérez López

Tots dos participem en l’anàlisi, el disseny, la implementació, les proves i la documentació.

## Tecnologies previstes

- **C# i WPF amb Visual Studio:** aplicació d’escriptori per a Windows.
- **Fitxers locals:** persistència inicial de les dades.
- **API i SGBD:** ampliació posterior per accedir a una base de dades.
- **Obsidian, Markdown i CSS:** documentació i exportació a PDF.
- **Jira:** planificació i seguiment amb sprints de dues setmanes.
- **Git i GitHub:** control de versions i treball en equip.

## Estat actual

El projecte es troba en fase de planificació. Disposem del repositori 
GitHub, del Product Backlog inicial a Jira i de les eines per redactar
i exportar la documentació amb Obsidian.

El següent pas és planificar el primer sprint, repartir les tasques
i començar el disseny inicial de l’aplicació. El projecte WPF encara
no s’ha creat.

## Estructura del projecte

```text
ProjecteKanban/
├── .obsidian/
│   ├── plugins/
│   │   └── memoria-pdf-css/     # Plugin d’exportació a PDF
│   └── community-plugins.json  # Llista de plugins comunitaris
├── documentacio/
│   └── memoria-pdf.css         # Estil dels documents exportats
├── .gitignore
└── README.md
```

Es mostra la part destinada a compartir-se amb Git.
Les configuracions personals d’Obsidian queden ignorades.

## Documentació

La documentació del projecte es redacta amb Obsidian en format
Markdown i es guarda a `documentacio/`.

Inclourà l’anàlisi de requisits, els diagrames, els prototips,
els informes dels sprints i els manuals d’usuari i d’instal·lació.
Els documents de lliurament s’exportaran a PDF.

## Organització

Equip de dues persones, amb metodologia Scrum i seguiment a Jira.
Les proves i la documentació s’actualitzaran durant cada sprint.

## Planificació i seguiment

Gestió del Product Backlog i els sprints: 
[Jira — ProjecteKanban](https://daviddam2.atlassian.net/jira/software/projects/KBAN/boards/34/backlog).
L’accés requereix iniciar sessió amb un compte autoritzat.