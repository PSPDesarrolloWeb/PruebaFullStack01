import { Component } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-update-user-dialog',
  templateUrl: './update-user-dialog.component.html',
  styleUrl: './update-user-dialog.component.sass'
})
export class UpdateUserDialogComponent {
  departaments: string[] = ['Legal', 'Tecnologías de la información', 'Ventas', 'Recursos Humanos', 'Marketing', 'Operaciones', 'Finanzas'];
  positions: string[] = ['Administrador', 'Líder Front End', 'Representante de ventas', 'Especialista en RRHH', 'Desarrollador Full Stack', 'Coordinador de Marketing', 'Gerente de Operaciones', 'Abogado Corporativo', 'Analista Financiero', 'Especialista en Capacitación'];

  constructor(public dialogRef: MatDialogRef<UpdateUserDialogComponent>) { }

  updateUser() {
    console.log('Actualizar datos del usuario');
  }

  onCancel(): void {
    this.dialogRef.close();
  }

}
