import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TopicsComponent } from './topics.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    component: TopicsComponent,
  },
];

@NgModule({
  declarations: [TopicsComponent],
  imports: [CommonModule, RouterModule.forChild(routes)],
})
export class TopicsModule {}
