import { Action } from "../action/Action";
import { JsonValue } from "type-fest";
import { Step } from "../step/Step";

export type Task = {
  action?: Action | null;
  context: JsonValue;
  createdAt: Date;
  id: string;
  kind?: "Human" | "System" | null;
  step?: Step | null;
  updatedAt: Date;
};
