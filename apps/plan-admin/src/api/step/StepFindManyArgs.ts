import { StepWhereInput } from "./StepWhereInput";
import { StepOrderByInput } from "./StepOrderByInput";

export type StepFindManyArgs = {
  where?: StepWhereInput;
  orderBy?: Array<StepOrderByInput>;
  skip?: number;
  take?: number;
};
