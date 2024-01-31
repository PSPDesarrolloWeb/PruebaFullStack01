import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { CreateUserDialogComponent } from '../../components/create-user-dialog/create-user-dialog.component'
import { UpdateUserDialogComponent } from '../../components/update-user-dialog/update-user-dialog.component';
import { ConfirmDialogComponent } from '../../components/confirm-dialog/confirm-dialog.component';


@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrl: './users.component.sass'
})
export class UsersComponent {


  employees = [
    { username: 'juanPerez', firstName: 'Juan', lastName: 'Pérez', departament: 'Tecnologías de la información', position: 'Administrador', email: 'juan.perez@example.com' },
    { username: 'mariaLopez', firstName: 'María', lastName: 'López', departament: 'Legal', position: 'Líder Front End', email: 'maria.lopez@example.com' },
    { username: 'carlosGonzalez', firstName: 'Carlos', lastName: 'González', departament: 'Ventas', position: 'Representante de ventas', email: 'carlos.gonzalez@example.com' },
    { username: 'lauraHernandez', firstName: 'Laura', lastName: 'Hernández', departament: 'Recursos Humanos', position: 'Especialista en RRHH', email: 'laura.hernandez@example.com' },
    { username: 'ricardoSilva', firstName: 'Ricardo', lastName: 'Silva', departament: 'Tecnologías de la información', position: 'Desarrollador Full Stack', email: 'ricardo.silva@example.com' },
    { username: 'claudiaBlanco', firstName: 'Claudia', lastName: 'Blanco', departament: 'Marketing', position: 'Coordinador de Marketing', email: 'claudia.blanco@example.com' },
    { username: 'fernandoVargas', firstName: 'Fernando', lastName: 'Vargas', departament: 'Operaciones', position: 'Gerente de Operaciones', email: 'fernando.vargas@example.com' },
    { username: 'anaRodriguez', firstName: 'Ana', lastName: 'Rodríguez', departament: 'Legal', position: 'Abogado Corporativo', email: 'ana.rodriguez@example.com' },
    { username: 'javierMartinez', firstName: 'Javier', lastName: 'Martínez', departament: 'Finanzas', position: 'Analista Financiero', email: 'javier.martinez@example.com' },
    { username: 'claraCastillo', firstName: 'Clara', lastName: 'Castillo', departament: 'Recursos Humanos', position: 'Especialista en Capacitación', email: 'clara.castillo@example.com' }
  ];


  displayedColumns: string[] = ['username', 'firstName', 'lastName', 'departament', 'position', 'email', 'actions'];
  departaments: string[] = ['Legal', 'Tecnologías de la información', 'Ventas', 'Recursos Humanos', 'Marketing', 'Operaciones', 'Finanzas'];
  positions: string[] = ['Administrador', 'Líder Front End', 'Representante de ventas', 'Especialista en RRHH', 'Desarrollador Full Stack', 'Coordinador de Marketing', 'Gerente de Operaciones', 'Abogado Corporativo', 'Analista Financiero', 'Especialista en Capacitación'];

  constructor(public dialog: MatDialog) { }

  openDialogCreate(): void {
    const dialogRef = this.dialog.open(CreateUserDialogComponent, {

    });

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }

  openDialogUpdate(): void {
    const dialogRef = this.dialog.open(UpdateUserDialogComponent, {

    });

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }

  openConfirmDialog(): void {
    const dialogRef = this.dialog.open(ConfirmDialogComponent);

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        // El usuario confirmó la acción de eliminación
        // Aquí puedes poner el código para eliminar el elemento
      } else {
        // El usuario canceló la acción de eliminación
      }
    });
  }

  editEmployee(employee: any) {
    console.log('Editar usuario');
  }

  deleteEmployee(employee: any) {
    console.log('Eliminar usuario');
  }
}
