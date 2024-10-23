import { Step as TStep } from "../api/step/Step";

export const STEP_TITLE_FIELD = "id";

export const StepTitle = (record: TStep): string => {
  return record.id?.toString() || String(record.id);
};
