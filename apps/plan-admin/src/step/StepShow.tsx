import * as React from "react";

import {
  Show,
  SimpleShowLayout,
  ShowProps,
  DateField,
  TextField,
  ReferenceField,
  ReferenceManyField,
  Datagrid,
} from "react-admin";

import { ACTION_TITLE_FIELD } from "../action/ActionTitle";
import { STEP_TITLE_FIELD } from "./StepTitle";
import { WORKFLOW_TITLE_FIELD } from "../workflow/WorkflowTitle";

export const StepShow = (props: ShowProps): React.ReactElement => {
  return (
    <Show {...props}>
      <SimpleShowLayout>
        <DateField source="createdAt" label="Created At" />
        <TextField label="ID" source="id" />
        <TextField label="Kind" source="kind" />
        <DateField source="updatedAt" label="Updated At" />
        <ReferenceField
          label="Workflow"
          source="workflow.id"
          reference="Workflow"
        >
          <TextField source={WORKFLOW_TITLE_FIELD} />
        </ReferenceField>
        <ReferenceManyField reference="Task" target="stepId" label="Tasks">
          <Datagrid rowClick="show" bulkActionButtons={false}>
            <ReferenceField
              label="Action"
              source="action.id"
              reference="Action"
            >
              <TextField source={ACTION_TITLE_FIELD} />
            </ReferenceField>
            <TextField label="Context" source="context" />
            <DateField source="createdAt" label="Created At" />
            <TextField label="ID" source="id" />
            <TextField label="Kind" source="kind" />
            <ReferenceField label="Step" source="step.id" reference="Step">
              <TextField source={STEP_TITLE_FIELD} />
            </ReferenceField>
            <DateField source="updatedAt" label="Updated At" />
          </Datagrid>
        </ReferenceManyField>
      </SimpleShowLayout>
    </Show>
  );
};
