import { Component } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-confirm-dialog',
  templateUrl: './confirm-dialog.component.html',
  styleUrl: './confirm-dialog.component.sass'
})
export class ConfirmDialogComponent {

  constructor(private dialogRef: MatDialogRef<ConfirmDialogComponent>) { }

  onConfirm(): void {
    this.dialogRef.close(true);
    console.log('Usuario eliminado');
  }

  onCancel(): void {
    this.dialogRef.close(false);
  }
}