import { Component, Injector } from '@angular/core';
import { LocalizacionUpsGenerated } from './localizacion-ups-generated.component';

@Component({
  selector: 'localizacion-ups',
  templateUrl: './localizacion-ups.component.html'
})
export class LocalizacionUpsComponent extends LocalizacionUpsGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
