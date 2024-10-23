import * as React from "react";
import {
  Show,
  SimpleShowLayout,
  ShowProps,
  ReferenceField,
  TextField,
  DateField,
} from "react-admin";
import { ACTION_TITLE_FIELD } from "../action/ActionTitle";
import { STEP_TITLE_FIELD } from "../step/StepTitle";

export const TaskShow = (props: ShowProps): React.ReactElement => {
  return (
    <Show {...props}>
      <SimpleShowLayout>
        <ReferenceField label="Action" source="action.id" reference="Action">
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
      </SimpleShowLayout>
    </Show>
  );
};
