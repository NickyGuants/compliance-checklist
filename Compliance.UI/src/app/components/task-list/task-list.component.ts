import {Component, OnInit} from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ComplianceTask } from '../../models/task.model';
import { ComplianceTaskService } from '../../services/compliance-task.service';
import {Category, Priority, Status} from '../../enums/enums';
import {AddTaskComponent} from '../add-task/add-task.component';

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  styleUrls: ['./task-list.component.css']
})
export class TaskListComponent implements OnInit {
  
  tasks: ComplianceTask[] = [];
  Category = Category;
  Priority = Priority;
  Status = Status;
  isLoading: boolean = false;

  constructor(private taskService: ComplianceTaskService, private modalService: NgbModal) { }

  ngOnInit(): void {
    this.loadTasks();
  }

  loadTasks() {
    this.isLoading = true;
    this.taskService.getTasks().subscribe({
      next: data => {
        this.tasks = data;
        this.isLoading = false;
      },
      error: error => {
        this.isLoading = false;
      }
    });
  }

  openForm() {
    const modalRef = this.modalService.open(AddTaskComponent, {ariaLabelledBy: 'modal-basic-title', centered: true});
    modalRef.componentInstance.taskAdded.subscribe((newTask: ComplianceTask) => {
      this.tasks.push(newTask);
    });
  }

  calculateFactorial() {
    this.isLoading = true;
    this.taskService.calculateFactorial().subscribe({
      next: data => {
        this.tasks = data;
        this.isLoading = false;
      },
      error: error => {
        this.isLoading = false;
      }
    });
  }
}
