import { Component, Injector } from '@angular/core';
import { DetalleOfertaGenerated } from './detalle-oferta-generated.component';

@Component({
  selector: 'detalle-oferta',
  templateUrl: './detalle-oferta.component.html'
})
export class DetalleOfertaComponent extends DetalleOfertaGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
