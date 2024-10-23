import { StringFilter } from "../../util/StringFilter";
import { StepListRelationFilter } from "../step/StepListRelationFilter";

export type WorkflowWhereInput = {
  id?: StringFilter;
  steps?: StepListRelationFilter;
};
