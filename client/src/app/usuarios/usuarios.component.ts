import { Component, Injector } from '@angular/core';
import { UsuariosGenerated } from './usuarios-generated.component';

@Component({
  selector: 'usuarios',
  templateUrl: './usuarios.component.html'
})
export class UsuariosComponent extends UsuariosGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
