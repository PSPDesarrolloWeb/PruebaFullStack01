import { Component } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-create-user-dialog',
  templateUrl: './create-user-dialog.component.html',
  styleUrl: './create-user-dialog.component.sass'
})
export class CreateUserDialogComponent {
  departaments: string[] = ['Legal', 'Tecnologías de la información', 'Ventas', 'Recursos Humanos', 'Marketing', 'Operaciones', 'Finanzas'];
  positions: string[] = ['Administrador', 'Líder Front End', 'Representante de ventas', 'Especialista en RRHH', 'Desarrollador Full Stack', 'Coordinador de Marketing', 'Gerente de Operaciones', 'Abogado Corporativo', 'Analista Financiero', 'Especialista en Capacitación'];


  constructor(public dialogRef: MatDialogRef<CreateUserDialogComponent>) { }

  registerUser() {
    console.log('Registrar usuario'); 
  }

  onCancel(): void {
    this.dialogRef.close();
  }

}
