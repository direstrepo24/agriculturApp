import { Component, Injector } from '@angular/core';
import { OfertaGenerated } from './oferta-generated.component';

@Component({
  selector: 'oferta',
  templateUrl: './oferta.component.html'
})
export class OfertaComponent extends OfertaGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
