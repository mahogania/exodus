import { Step } from "../step/Step";

export type Workflow = {
  createdAt: Date;
  id: string;
  steps?: Array<Step>;
  updatedAt: Date;
};
