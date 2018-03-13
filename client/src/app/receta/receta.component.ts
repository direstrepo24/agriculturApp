import { Component, Injector } from '@angular/core';
import { RecetaGenerated } from './receta-generated.component';

@Component({
  selector: 'receta',
  templateUrl: './receta.component.html'
})
export class RecetaComponent extends RecetaGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
