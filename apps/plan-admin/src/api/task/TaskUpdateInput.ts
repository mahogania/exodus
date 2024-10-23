import { ActionWhereUniqueInput } from "../action/ActionWhereUniqueInput";
import { InputJsonValue } from "../../types";
import { StepWhereUniqueInput } from "../step/StepWhereUniqueInput";

export type TaskUpdateInput = {
  action?: ActionWhereUniqueInput | null;
  context?: InputJsonValue;
  kind?: "Human" | "System" | null;
  step?: StepWhereUniqueInput | null;
};
