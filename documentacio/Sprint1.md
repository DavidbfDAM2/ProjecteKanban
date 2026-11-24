# 2026-11-24

## Tasques a fer:

- [ ] Planificar i documentar Sprint 1
- [ ] Fer prototip del tauler Kanban
- [ ] Definir les classes principals i elaborar el diagrama
- [ ] Definir l'organització modular del projecte
- [ ] Fer el prototip del formulari de tasques
- [ ] Fer el prototip de la gestió de responsables
## Planificació i repartició de les tasques:
### Ivan
Prototip del disseny Kanban amb [Excalidraw](https://excalidraw.com/) 

![[1rEsborrany.png]]
### David
Gestió dels comptes de [Jira](https://daviddam2.atlassian.net/jira/software/projects/KBAN/boards/34/backlog) i [GitHub](https://github.com/DavidbfDAM2/ProjecteKanban)

### Isaac
Documentar Sprint

### Equip

Definir classes principals i pensar taules BBDD

## BBDD

| **Usuari**  | **Projecte**   | **Columna**    | **Tasca**           |
| ----------- | -------------- | -------------- | ------------------- |
| userId (PK) | projectId (PK) | columnId (PK)  | tascaId (PK)        |
| nom         | Manager (FK)   | idProject (PK) | descripció          |
| password    | nomProj        | nomColumn      | dataCreacio         |
|             | dataCreacio    |                | dataFinal           |
|             | dataFinal      |                | dataMod             |
|             |                |                | responsable(userId) |
|             |                |                | idColumn (FK)       |
|             |                |                | prioritat           |
*Esquema provisional de les taules de la BBDD*