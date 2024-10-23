import { ActionWhereUniqueInput } from "../action/ActionWhereUniqueInput";
import { JsonFilter } from "../../util/JsonFilter";
import { StringFilter } from "../../util/StringFilter";
import { StepWhereUniqueInput } from "../step/StepWhereUniqueInput";

export type TaskWhereInput = {
  action?: ActionWhereUniqueInput;
  context?: JsonFilter;
  id?: StringFilter;
  kind?: "Human" | "System";
  step?: StepWhereUniqueInput;
};
