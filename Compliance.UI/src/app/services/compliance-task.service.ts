import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ComplianceTask } from '../models/task.model';
import {ComplianceTaskRequest} from '../models/task.request';

@Injectable({
  providedIn: 'root'
})
export class ComplianceTaskService {
  private apiUrl = 'http://localhost:5000/api/ComplianceTask';

  constructor(private http: HttpClient) {}

  getTasks(): Observable<ComplianceTask[]> {
    return this.http.get<ComplianceTask[]>(`${this.apiUrl}/tasks`);
  }

  addTask(task: ComplianceTaskRequest): Observable<ComplianceTask> {
    return this.http.post<ComplianceTask>(`${this.apiUrl}/task`, task);
  }

  //TODO: Implement streaming to support displaying the results as each item's data processing is completed.
  calculateFactorial(): Observable<ComplianceTask[]> {
    return this.http.get<ComplianceTask[]>(`${this.apiUrl}/tasks/factorial`);
  }

}
