import { Object } from "../object/Object";
import { Task } from "../task/Task";

export type Action = {
  createdAt: Date;
  id: string;
  object?: Object | null;
  tasks?: Array<Task>;
  updatedAt: Date;
};
