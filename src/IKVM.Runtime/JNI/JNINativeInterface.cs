﻿using System.Runtime.InteropServices;

namespace IKVM.Runtime.JNI
{
    [StructLayout(LayoutKind.Sequential)]
    unsafe struct JNINativeInterface
    {

        /// <summary>
        /// Maintains a <see cref="JNINativeInterface"/> structure in memory.
        /// </summary>
        class ManagedRef
        {

            internal readonly JNINativeInterface* ptr;

            /// <summary>
            /// Initializes a new instance.
            /// </summary>
            public ManagedRef()
            {
                ptr = (JNINativeInterface*)Marshal.AllocHGlobal(sizeof(JNINativeInterface));
            }

            /// <summary>
            /// Finalizes the instance.
            /// </summary>
            ~ManagedRef()
            {
                Marshal.FreeHGlobal((nint)ptr);
            }

        }

        static readonly ManagedRef _ni = new();
        static readonly JNINativeInterface* ni = _ni.ptr;

        /// <summary>
        /// Gets a pointer to the JNINativeInterface table.
        /// </summary>
        public static JNINativeInterface* Pointer => ni;

        /// <summary>
        /// Initializes the static instance.
        /// </summary>
        static JNINativeInterface()
        {
            JNIVM.jvmCreated = true;

            ni->GetMethodArgs = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetMethodArgs);
            ni->reserved1 = null;
            ni->reserved2 = null;

            ni->reserved3 = null;
            ni->GetVersion = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetVersion);

            ni->DefineClass = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.DefineClass);
            ni->FindClass = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.FindClass);

            ni->FromReflectedMethod = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.FromReflectedMethod);
            ni->FromReflectedField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.FromReflectedField);
            ni->ToReflectedMethod = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.ToReflectedMethod);

            ni->GetSuperclass = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetSuperclass);
            ni->IsAssignableFrom = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.IsAssignableFrom);

            ni->ToReflectedField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.ToReflectedField);

            ni->Throw = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.Throw);
            ni->ThrowNew = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.ThrowNew);
            ni->ExceptionOccurred = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.ExceptionOccurred);
            ni->ExceptionDescribe = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.ExceptionDescribe);
            ni->ExceptionClear = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.ExceptionClear);
            ni->FatalError = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.FatalError);

            ni->PushLocalFrame = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.PushLocalFrame);
            ni->PopLocalFrame = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.PopLocalFrame);

            ni->NewGlobalRef = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.NewGlobalRef);
            ni->DeleteGlobalRef = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.DeleteGlobalRef);
            ni->DeleteLocalRef = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.DeleteLocalRef);
            ni->IsSameObject = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.IsSameObject);

            ni->NewLocalRef = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.NewLocalRef);
            ni->EnsureLocalCapacity = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.EnsureLocalCapacity);

            ni->AllocObject = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.AllocObject);
            ni->NewObject = (void*)Native.GetExport("JNI_NewObject", 3);
            ni->NewObjectV = (void*)Native.GetExport("JNI_NewObjectV", 3);
            ni->NewObjectA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.NewObjectA);

            ni->GetObjectClass = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetObjectClass);
            ni->IsInstanceOf = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.IsInstanceOf);

            ni->GetMethodID = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetMethodID);

            ni->CallObjectMethod = (void*)Native.GetExport("JNI_CallObjectMethod", 3);
            ni->CallObjectMethodV = (void*)Native.GetExport("JNI_CallObjectMethodV", 3);
            ni->CallObjectMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallObjectMethodA);

            ni->CallBooleanMethod = (void*)Native.GetExport("JNI_CallBooleanMethod", 3);
            ni->CallBooleanMethodV = (void*)Native.GetExport("JNI_CallBooleanMethodV", 3);
            ni->CallBooleanMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallBooleanMethodA);

            ni->CallByteMethod = (void*)Native.GetExport("JNI_CallByteMethod", 3);
            ni->CallByteMethodV = (void*)Native.GetExport("JNI_CallByteMethodV", 3);
            ni->CallByteMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallByteMethodA);

            ni->CallCharMethod = (void*)Native.GetExport("JNI_CallCharMethod", 3);
            ni->CallCharMethodV = (void*)Native.GetExport("JNI_CallCharMethodV", 3);
            ni->CallCharMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallCharMethodA);

            ni->CallShortMethod = (void*)Native.GetExport("JNI_CallShortMethod", 3);
            ni->CallShortMethodV = (void*)Native.GetExport("JNI_CallShortMethodV", 3);
            ni->CallShortMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallShortMethodA);

            ni->CallIntMethod = (void*)Native.GetExport("JNI_CallIntMethod", 3);
            ni->CallIntMethodV = (void*)Native.GetExport("JNI_CallIntMethodV", 3);
            ni->CallIntMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallIntMethodA);

            ni->CallLongMethod = (void*)Native.GetExport("JNI_CallLongMethod", 3);
            ni->CallLongMethodV = (void*)Native.GetExport("JNI_CallLongMethodV", 3);
            ni->CallLongMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallLongMethodA);

            ni->CallFloatMethod = (void*)Native.GetExport("JNI_CallFloatMethod", 3);
            ni->CallFloatMethodV = (void*)Native.GetExport("JNI_CallFloatMethodV", 3);
            ni->CallFloatMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallFloatMethodA);

            ni->CallDoubleMethod = (void*)Native.GetExport("JNI_CallDoubleMethod", 3);
            ni->CallDoubleMethodV = (void*)Native.GetExport("JNI_CallDoubleMethodV", 3);
            ni->CallDoubleMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallDoubleMethodA);

            ni->CallVoidMethod = (void*)Native.GetExport("JNI_CallVoidMethod", 3);
            ni->CallVoidMethodV = (void*)Native.GetExport("JNI_CallVoidMethodV", 3);
            ni->CallVoidMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallVoidMethodA);

            ni->CallNonvirtualObjectMethod = (void*)Native.GetExport("JNI_CallNonvirtualObjectMethod", 4);
            ni->CallNonvirtualObjectMethodV = (void*)Native.GetExport("JNI_CallNonvirtualObjectMethodV", 4);
            ni->CallNonvirtualObjectMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallNonvirtualObjectMethodA);

            ni->CallNonvirtualBooleanMethod = (void*)Native.GetExport("JNI_CallNonvirtualBooleanMethod", 4);
            ni->CallNonvirtualBooleanMethodV = (void*)Native.GetExport("JNI_CallNonvirtualBooleanMethodV", 4);
            ni->CallNonvirtualBooleanMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallNonvirtualBooleanMethodA);

            ni->CallNonvirtualByteMethod = (void*)Native.GetExport("JNI_CallNonvirtualByteMethod", 4);
            ni->CallNonvirtualByteMethodV = (void*)Native.GetExport("JNI_CallNonvirtualByteMethodV", 4);
            ni->CallNonvirtualByteMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallNonvirtualByteMethodA);

            ni->CallNonvirtualCharMethod = (void*)Native.GetExport("JNI_CallNonvirtualCharMethod", 4);
            ni->CallNonvirtualCharMethodV = (void*)Native.GetExport("JNI_CallNonvirtualCharMethodV", 4);
            ni->CallNonvirtualCharMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallNonvirtualCharMethodA);

            ni->CallNonvirtualShortMethod = (void*)Native.GetExport("JNI_CallNonvirtualShortMethod", 4);
            ni->CallNonvirtualShortMethodV = (void*)Native.GetExport("JNI_CallNonvirtualShortMethodV", 4);
            ni->CallNonvirtualShortMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallNonvirtualShortMethodA);

            ni->CallNonvirtualIntMethod = (void*)Native.GetExport("JNI_CallNonvirtualIntMethod", 4);
            ni->CallNonvirtualIntMethodV = (void*)Native.GetExport("JNI_CallNonvirtualIntMethodV", 4);
            ni->CallNonvirtualIntMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallNonvirtualIntMethodA);

            ni->CallNonvirtualLongMethod = (void*)Native.GetExport("JNI_CallNonvirtualLongMethod", 4);
            ni->CallNonvirtualLongMethodV = (void*)Native.GetExport("JNI_CallNonvirtualLongMethodV", 4);
            ni->CallNonvirtualLongMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallNonvirtualLongMethodA);

            ni->CallNonvirtualFloatMethod = (void*)Native.GetExport("JNI_CallNonvirtualFloatMethod", 4);
            ni->CallNonvirtualFloatMethodV = (void*)Native.GetExport("JNI_CallNonvirtualFloatMethodV", 4);
            ni->CallNonvirtualFloatMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallNonvirtualFloatMethodA);

            ni->CallNonvirtualDoubleMethod = (void*)Native.GetExport("JNI_CallNonvirtualDoubleMethod", 4);
            ni->CallNonvirtualDoubleMethodV = (void*)Native.GetExport("JNI_CallNonvirtualDoubleMethodV", 4);
            ni->CallNonvirtualDoubleMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallNonvirtualDoubleMethodA);

            ni->CallNonvirtualVoidMethod = (void*)Native.GetExport("JNI_CallNonvirtualVoidMethod", 4);
            ni->CallNonvirtualVoidMethodV = (void*)Native.GetExport("JNI_CallNonvirtualVoidMethodV", 4);
            ni->CallNonvirtualVoidMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallNonvirtualVoidMethodA);

            ni->GetFieldID = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetFieldID);

            ni->GetObjectField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetObjectField);
            ni->GetBooleanField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetBooleanField);
            ni->GetByteField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetByteField);
            ni->GetCharField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetCharField);
            ni->GetShortField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetShortField);
            ni->GetIntField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetIntField);
            ni->GetLongField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetLongField);
            ni->GetFloatField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetFloatField);
            ni->GetDoubleField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetDoubleField);

            ni->SetObjectField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetObjectField);
            ni->SetBooleanField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetBooleanField);
            ni->SetByteField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetByteField);
            ni->SetCharField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetCharField);
            ni->SetShortField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetShortField);
            ni->SetIntField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetIntField);
            ni->SetLongField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetLongField);
            ni->SetFloatField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetFloatField);
            ni->SetDoubleField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetDoubleField);

            ni->GetStaticMethodID = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetStaticMethodID);

            ni->CallStaticObjectMethod = (void*)Native.GetExport("JNI_CallStaticObjectMethod", 3);
            ni->CallStaticObjectMethodV = (void*)Native.GetExport("JNI_CallStaticObjectMethodV", 3);
            ni->CallStaticObjectMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallStaticObjectMethodA);

            ni->CallStaticBooleanMethod = (void*)Native.GetExport("JNI_CallStaticBooleanMethod", 3);
            ni->CallStaticBooleanMethodV = (void*)Native.GetExport("JNI_CallStaticBooleanMethodV", 3);
            ni->CallStaticBooleanMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallStaticBooleanMethodA);

            ni->CallStaticByteMethod = (void*)Native.GetExport("JNI_CallStaticByteMethod", 3);
            ni->CallStaticByteMethodV = (void*)Native.GetExport("JNI_CallStaticByteMethodV", 3);
            ni->CallStaticByteMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallStaticByteMethodA);

            ni->CallStaticCharMethod = (void*)Native.GetExport("JNI_CallStaticCharMethod", 3);
            ni->CallStaticCharMethodV = (void*)Native.GetExport("JNI_CallStaticCharMethodV", 3);
            ni->CallStaticCharMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallStaticCharMethodA);

            ni->CallStaticShortMethod = (void*)Native.GetExport("JNI_CallStaticShortMethod", 3);
            ni->CallStaticShortMethodV = (void*)Native.GetExport("JNI_CallStaticShortMethodV", 3);
            ni->CallStaticShortMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallStaticShortMethodA);

            ni->CallStaticIntMethod = (void*)Native.GetExport("JNI_CallStaticIntMethod", 3);
            ni->CallStaticIntMethodV = (void*)Native.GetExport("JNI_CallStaticIntMethodV", 3);
            ni->CallStaticIntMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallStaticIntMethodA);

            ni->CallStaticLongMethod = (void*)Native.GetExport("JNI_CallStaticLongMethod", 3);
            ni->CallStaticLongMethodV = (void*)Native.GetExport("JNI_CallStaticLongMethodV", 3);
            ni->CallStaticLongMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallStaticLongMethodA);

            ni->CallStaticFloatMethod = (void*)Native.GetExport("JNI_CallStaticFloatMethod", 3);
            ni->CallStaticFloatMethodV = (void*)Native.GetExport("JNI_CallStaticFloatMethodV", 3);
            ni->CallStaticFloatMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallStaticFloatMethodA);

            ni->CallStaticDoubleMethod = (void*)Native.GetExport("JNI_CallStaticDoubleMethod", 3);
            ni->CallStaticDoubleMethodV = (void*)Native.GetExport("JNI_CallStaticDoubleMethodV", 3);
            ni->CallStaticDoubleMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallStaticDoubleMethodA);

            ni->CallStaticVoidMethod = (void*)Native.GetExport("JNI_CallStaticVoidMethod", 3);
            ni->CallStaticVoidMethodV = (void*)Native.GetExport("JNI_CallStaticVoidMethodV", 3);
            ni->CallStaticVoidMethodA = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.CallStaticVoidMethodA);

            ni->GetStaticFieldID = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetStaticFieldID);

            ni->GetStaticObjectField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetStaticObjectField);
            ni->GetStaticBooleanField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetStaticBooleanField);
            ni->GetStaticByteField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetStaticByteField);
            ni->GetStaticCharField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetStaticCharField);
            ni->GetStaticShortField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetStaticShortField);
            ni->GetStaticIntField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetStaticIntField);
            ni->GetStaticLongField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetStaticLongField);
            ni->GetStaticFloatField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetStaticFloatField);
            ni->GetStaticDoubleField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetStaticDoubleField);

            ni->SetStaticObjectField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetStaticObjectField);
            ni->SetStaticBooleanField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetStaticBooleanField);
            ni->SetStaticByteField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetStaticByteField);
            ni->SetStaticCharField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetStaticCharField);
            ni->SetStaticShortField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetStaticShortField);
            ni->SetStaticIntField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetStaticIntField);
            ni->SetStaticLongField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetStaticLongField);
            ni->SetStaticFloatField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetStaticFloatField);
            ni->SetStaticDoubleField = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetStaticDoubleField);

            ni->NewString = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.NewString);
            ni->GetStringLength = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetStringLength);
            ni->GetStringChars = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetStringChars);
            ni->ReleaseStringChars = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.ReleaseStringChars);

            ni->NewStringUTF = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.NewStringUTF);
            ni->GetStringUTFLength = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetStringUTFLength);
            ni->GetStringUTFChars = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetStringUTFChars);
            ni->ReleaseStringUTFChars = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.ReleaseStringUTFChars);

            ni->GetArrayLength = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetArrayLength);

            ni->NewObjectArray = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.NewObjectArray);
            ni->GetObjectArrayElement = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetObjectArrayElement);
            ni->SetObjectArrayElement = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetObjectArrayElement);

            ni->NewBooleanArray = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.NewBooleanArray);
            ni->NewByteArray = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.NewByteArray);
            ni->NewCharArray = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.NewCharArray);
            ni->NewShortArray = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.NewShortArray);
            ni->NewIntArray = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.NewIntArray);
            ni->NewLongArray = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.NewLongArray);
            ni->NewFloatArray = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.NewFloatArray);
            ni->NewDoubleArray = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.NewDoubleArray);

            ni->GetBooleanArrayElements = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetBooleanArrayElements);
            ni->GetByteArrayElements = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetByteArrayElements);
            ni->GetCharArrayElements = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetCharArrayElements);
            ni->GetShortArrayElements = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetShortArrayElements);
            ni->GetIntArrayElements = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetIntArrayElements);
            ni->GetLongArrayElements = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetLongArrayElements);
            ni->GetFloatArrayElements = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetFloatArrayElements);
            ni->GetDoubleArrayElements = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetDoubleArrayElements);

            ni->ReleaseBooleanArrayElements = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.ReleaseBooleanArrayElements);
            ni->ReleaseByteArrayElements = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.ReleaseByteArrayElements);
            ni->ReleaseCharArrayElements = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.ReleaseCharArrayElements);
            ni->ReleaseShortArrayElements = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.ReleaseShortArrayElements);
            ni->ReleaseIntArrayElements = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.ReleaseIntArrayElements);
            ni->ReleaseLongArrayElements = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.ReleaseLongArrayElements);
            ni->ReleaseFloatArrayElements = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.ReleaseFloatArrayElements);
            ni->ReleaseDoubleArrayElements = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.ReleaseDoubleArrayElements);

            ni->GetBooleanArrayRegion = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetBooleanArrayRegion);
            ni->GetByteArrayRegion = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetByteArrayRegion);
            ni->GetCharArrayRegion = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetCharArrayRegion);
            ni->GetShortArrayRegion = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetShortArrayRegion);
            ni->GetIntArrayRegion = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetIntArrayRegion);
            ni->GetLongArrayRegion = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetLongArrayRegion);
            ni->GetFloatArrayRegion = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetFloatArrayRegion);
            ni->GetDoubleArrayRegion = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetDoubleArrayRegion);

            ni->SetBooleanArrayRegion = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetBooleanArrayRegion);
            ni->SetByteArrayRegion = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetByteArrayRegion);
            ni->SetCharArrayRegion = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetCharArrayRegion);
            ni->SetShortArrayRegion = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetShortArrayRegion);
            ni->SetIntArrayRegion = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetIntArrayRegion);
            ni->SetLongArrayRegion = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetLongArrayRegion);
            ni->SetFloatArrayRegion = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetFloatArrayRegion);
            ni->SetDoubleArrayRegion = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.SetDoubleArrayRegion);

            ni->RegisterNatives = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.RegisterNatives);
            ni->UnregisterNatives = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.UnregisterNatives);

            ni->MonitorEnter = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.MonitorEnter);
            ni->MonitorExit = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.MonitorExit);

            ni->GetJavaVM = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetJavaVM);

            ni->GetStringRegion = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetStringRegion);
            ni->GetStringUTFRegion = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetStringUTFRegion);

            ni->GetPrimitiveArrayCritical = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetPrimitiveArrayCritical);
            ni->ReleasePrimitiveArrayCritical = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.ReleasePrimitiveArrayCritical);

            ni->GetStringCritical = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetStringCritical);
            ni->ReleaseStringCritical = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.ReleaseStringCritical);

            ni->NewWeakGlobalRef = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.NewWeakGlobalRef);
            ni->DeleteWeakGlobalRef = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.DeleteWeakGlobalRef);

            ni->ExceptionCheck = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.ExceptionCheck);

            ni->NewDirectByteBuffer = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.NewDirectByteBuffer);
            ni->GetDirectBufferAddress = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetDirectBufferAddress);
            ni->GetDirectBufferCapacity = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetDirectBufferCapacity);

            ni->GetObjectRefType = (void*)Marshal.GetFunctionPointerForDelegate(JNIEnv.GetObjectRefType);
        }

#if NET5

        public delegate* unmanaged[Cdecl]<JNIEnv*, jmethodID, byte*, int> GetMethodArgs;
        public void* reserved1;
        public void* reserved2;

        public void* reserved3;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jint> GetVersion;
        public delegate* unmanaged[Cdecl]<JNIEnv*, in byte*, jobject, jbyte*, jsize, jclass> DefineClass;
        public delegate* unmanaged[Cdecl]<JNIEnv*, in byte*, jclass> FindClass;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jmethodID> FromReflectedMethod;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jfieldID> FromReflectedField;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jmethodID, jboolean, jobject> ToReflectedMethod;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jclass> GetSuperclass;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jclass, jboolean> IsAssignableFrom;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jfieldID, jboolean, jobject> ToReflectedField;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jthrowable, jint> Throw;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, in byte*, jint> ThrowNew;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jthrowable> ExceptionOccurred;
        public delegate* unmanaged[Cdecl]<JNIEnv*, void> ExceptionDescribe;
        public delegate* unmanaged[Cdecl]<JNIEnv*, void> ExceptionClear;
        public delegate* unmanaged[Cdecl]<JNIEnv*, in byte*, void> FatalError;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jint, jint> PushLocalFrame;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jobject> PopLocalFrame;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jobject> NewGlobalRef;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, void> DeleteGlobalRef;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, void> DeleteLocalRef;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jobject, jboolean> IsSameObject;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jobject> NewLocalRef;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jint, jint> EnsureLocalCapacity;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jobject> AllocObject;
        public void* NewObject;
        public void* NewObjectV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jmethodID, ref jvalue> NewObjectA;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jclass> GetObjectClass;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jclass, jboolean> IsInstanceOf;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, in byte, in byte, jmethodID> GetMethodID;

        public void* CallObjectMethod;
        public void* CallObjectMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jmethodID, in jvalue, jobject> CallObjectMethodA;

        public void* CallBooleanMethod;
        public void* CallBooleanMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jmethodID, in jvalue, jboolean> CallBooleanMethodA;

        public void* CallByteMethod;
        public void* CallByteMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jmethodID, in jvalue, jbyte> CallByteMethodA;

        public void* CallCharMethod;
        public void* CallCharMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jmethodID, in jvalue, jchar> CallCharMethodA;

        public void* CallShortMethod;
        public void* CallShortMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jmethodID, in jvalue, jshort> CallShortMethodA;

        public void* CallIntMethod;
        public void* CallIntMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jmethodID, in jvalue, jint> CallIntMethodA;

        public void* CallLongMethod;
        public void* CallLongMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jmethodID, in jvalue, jlong> CallLongMethodA;

        public void* CallFloatMethod;
        public void* CallFloatMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jmethodID, in jvalue, jfloat> CallFloatMethodA;

        public void* CallDoubleMethod;
        public void* CallDoubleMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jmethodID, in jvalue, jdouble> CallDoubleMethodA;

        public void* CallVoidMethod;
        public void* CallVoidMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jmethodID, in jvalue, void> CallVoidMethodA;

        public void* CallNonvirtualObjectMethod;
        public void* CallNonvirtualObjectMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jclass, jmethodID, in jvalue, jobject> CallNonvirtualObjectMethodA;

        public void* CallNonvirtualBooleanMethod;
        public void* CallNonvirtualBooleanMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jclass, jmethodID, in jvalue, jboolean> CallNonvirtualBooleanMethodA;

        public void* CallNonvirtualByteMethod;
        public void* CallNonvirtualByteMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jclass, jmethodID, in jvalue, jbyte> CallNonvirtualByteMethodA;

        public void* CallNonvirtualCharMethod;
        public void* CallNonvirtualCharMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jclass, jmethodID, in jvalue, jchar> CallNonvirtualCharMethodA;

        public void* CallNonvirtualShortMethod;
        public void* CallNonvirtualShortMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jclass, jmethodID, in jvalue, jshort> CallNonvirtualShortMethodA;

        public void* CallNonvirtualIntMethod;
        public void* CallNonvirtualIntMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jclass, jmethodID, in jvalue, jint> CallNonvirtualIntMethodA;

        public void* CallNonvirtualLongMethod;
        public void* CallNonvirtualLongMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jclass, jmethodID, in jvalue, jlong> CallNonvirtualLongMethodA;

        public void* CallNonvirtualFloatMethod;
        public void* CallNonvirtualFloatMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jclass, jmethodID, in jvalue, jfloat> CallNonvirtualFloatMethodA;

        public void* CallNonvirtualDoubleMethod;
        public void* CallNonvirtualDoubleMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jclass, jmethodID, in jvalue, jdouble> CallNonvirtualDoubleMethodA;

        public void* CallNonvirtualVoidMethod;
        public void* CallNonvirtualVoidMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jclass, jmethodID, in jvalue, void> CallNonvirtualVoidMethodA;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, in byte, in byte, jfieldID> GetFieldID;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jfieldID, jobject> GetObjectField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jfieldID, jboolean> GetBooleanField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jfieldID, jbyte> GetByteField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jfieldID, jchar> GetCharField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jfieldID, jshort> GetShortField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jfieldID, jint> GetIntField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jfieldID, jlong> GetLongField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jfieldID, jfloat> GetFloatField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jfieldID, jdouble> GetDoubleField;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jfieldID, jobject, void> SetObjectField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jfieldID, jboolean, void> SetBooleanField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jfieldID, jbyte, void> SetByteField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jfieldID, jchar, void> SetCharField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jfieldID, jshort, void> SetShortField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jfieldID, jint, void> SetIntField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jfieldID, jlong, void> SetLongField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jfieldID, jfloat, void> SetFloatField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jfieldID, jdouble, void> SetDoubleField;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, byte, byte, jmethodID> GetStaticMethodID;

        public void* CallStaticObjectMethod;
        public void* CallStaticObjectMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jmethodID, in jvalue, jobject> CallStaticObjectMethodA;

        public void* CallStaticBooleanMethod;
        public void* CallStaticBooleanMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jmethodID, in jvalue, jboolean> CallStaticBooleanMethodA;

        public void* CallStaticByteMethod;
        public void* CallStaticByteMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jmethodID, in jvalue, jbyte> CallStaticByteMethodA;

        public void* CallStaticCharMethod;
        public void* CallStaticCharMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jmethodID, in jvalue, jchar> CallStaticCharMethodA;

        public void* CallStaticShortMethod;
        public void* CallStaticShortMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jmethodID, in jvalue, jshort> CallStaticShortMethodA;

        public void* CallStaticIntMethod;
        public void* CallStaticIntMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jmethodID, in jvalue, jint> CallStaticIntMethodA;

        public void* CallStaticLongMethod;
        public void* CallStaticLongMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jmethodID, in jvalue, jlong> CallStaticLongMethodA;

        public void* CallStaticFloatMethod;
        public void* CallStaticFloatMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jmethodID, in jvalue, jfloat> CallStaticFloatMethodA;

        public void* CallStaticDoubleMethod;
        public void* CallStaticDoubleMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jmethodID, in jvalue, jdouble> CallStaticDoubleMethodA;

        public void* CallStaticVoidMethod;
        public void* CallStaticVoidMethodV;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jmethodID, in jvalue, void> CallStaticVoidMethodA;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, in byte, in byte, jfieldID> GetStaticFieldID;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jfieldID, jobject> GetStaticObjectField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jfieldID, jboolean> GetStaticBooleanField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jfieldID, jbyte> GetStaticByteField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jfieldID, jchar> GetStaticCharField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jfieldID, jshort> GetStaticShortField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jfieldID, jint> GetStaticIntField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jfieldID, jlong> GetStaticLongField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jfieldID, jfloat> GetStaticFloatField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jfieldID, jdouble> GetStaticDoubleField;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jfieldID, jobject, void> SetStaticObjectField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jfieldID, jboolean, void> SetStaticBooleanField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jfieldID, jbyte, void> SetStaticByteField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jfieldID, jchar, void> SetStaticCharField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jfieldID, jshort, void> SetStaticShortField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jfieldID, jint, void> SetStaticIntField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jfieldID, jlong, void> SetStaticLongField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jfieldID, jfloat, void> SetStaticFloatField;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jfieldID, jdouble, void> SetStaticDoubleField;

        public delegate* unmanaged[Cdecl]<JNIEnv*, in jchar, jsize, jstring> NewString;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jstring, jsize> GetStringLength;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jstring, jboolean*, jchar*> GetStringChars;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jstring, jchar*, void> ReleaseStringChars;

        public delegate* unmanaged[Cdecl]<JNIEnv*, in byte, jstring> NewStringUTF;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jstring, jsize> GetStringUTFLength;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jstring, jboolean, byte*> GetStringUTFChars;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jstring, byte, void> ReleaseStringUTFChars;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jarray, jsize> GetArrayLength;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jsize, jclass, jobject, jobjectArray> NewObjectArray;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobjectArray, jsize, jobject> GetObjectArrayElement;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jsize, jvalue, void> SetObjectArrayElement;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jsize, jbooleanArray> NewBooleanArray;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jsize, jbyteArray> NewByteArray;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jsize, jcharArray> NewCharArray;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jsize, jshortArray> NewShortArray;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jsize, jintArray> NewIntArray;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jsize, jlongArray> NewLongArray;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jsize, jfloatArray> NewFloatArray;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jsize, jdoubleArray> NewDoubleArray;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jbooleanArray, jboolean*, jboolean*> GetBooleanArrayElements;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jbyteArray, jboolean*, jbyte*> GetByteArrayElements;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jcharArray, jboolean*, jchar*> GetCharArrayElements;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jshortArray, jboolean*, jshort*> GetShortArrayElements;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jintArray, jboolean*, jint*> GetIntArrayElements;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jlongArray, jboolean*, jlong*> GetLongArrayElements;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jfloatArray, jboolean*, jfloat*> GetFloatArrayElements;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jdoubleArray, jboolean*, jdouble*> GetDoubleArrayElements;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jbooleanArray, jboolean*, jint, void> ReleaseBooleanArrayElements;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jbyteArray, jbyte*, jint, void> ReleaseByteArrayElements;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jcharArray, jchar*, jint, void> ReleaseCharArrayElements;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jshortArray, jshort*, jint, void> ReleaseShortArrayElements;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jintArray, jint*, jint, void> ReleaseIntArrayElements;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jlongArray, jlong*, jint, void> ReleaseLongArrayElements;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jfloatArray, jfloat*, jint, void> ReleaseFloatArrayElements;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jdoubleArray, jdouble*, jint, void> ReleaseDoubleArrayElements;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jbooleanArray, jsize, jsize, jboolean*, void> GetBooleanArrayRegion;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jbyteArray, jsize, jsize, jbyte*, void> GetByteArrayRegion;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jcharArray, jsize, jsize, jchar*, void> GetCharArrayRegion;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jshortArray, jsize, jsize, jshort*, void> GetShortArrayRegion;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jintArray, jsize, jsize, jint*, void> GetIntArrayRegion;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jlongArray, jsize, jsize, jlong*, void> GetLongArrayRegion;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jfloatArray, jsize, jsize, jfloat*, void> GetFloatArrayRegion;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jdoubleArray, jsize, jsize, jdouble*, void> GetDoubleArrayRegion;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jbooleanArray, jsize, jsize, in jboolean, void> SetBooleanArrayRegion;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jbyteArray, jsize, jsize, in jbyte, void> SetByteArrayRegion;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jcharArray, jsize, jsize, in jchar, void> SetCharArrayRegion;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jshortArray, jsize, jsize, in jshort, void> SetShortArrayRegion;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jintArray, jsize, jsize, in jint, void> SetIntArrayRegion;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jlongArray, jsize, jsize, in jlong, void> SetLongArrayRegion;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jfloatArray, jsize, jsize, in jfloat, void> SetFloatArrayRegion;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jdoubleArray, jsize, jsize, in jdouble, void> SetDoubleArrayRegion;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, in JNINativeMethod, jint, jint> RegisterNatives;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jclass, jint> UnegisterNatives;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jint> MonitorEnter;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jint> MonitorExit;

        public delegate* unmanaged[Cdecl]<JNIEnv*, JavaVM**, jint> GetJavaVM;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jstring, jsize, jsize, out jchar, void> GetStringRegion;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jstring, jsize, jsize, out byte, void> GetStringUTFRegion;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jarray, out jboolean, void*> GetPrimitiveArrayCritical;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jarray, void*, void> ReleasePrimitiveArrayCritical;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jstring, out jboolean, ref jchar> GetStringCritical;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jstring, in jchar, void> ReleaseStringCritical;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jweak> NewWeakGlobalRef;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jweak, void> DeleteWeakGlobalRef;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jboolean> ExceptionCheck;

        public delegate* unmanaged[Cdecl]<JNIEnv*, void*, jlong, jobject> NewDirectByteBuffer;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, void*> GetDirectBufferAddress;
        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jlong> GetDirectBufferCapacity;

        public delegate* unmanaged[Cdecl]<JNIEnv*, jobject, jobjectRefType> GetObjectRefType;

#else

        public void* GetMethodArgs;
        public void* reserved1;
        public void* reserved2;

        public void* reserved3;
        public void* GetVersion;
        public void* DefineClass;
        public void* FindClass;

        public void* FromReflectedMethod;
        public void* FromReflectedField;

        public void* ToReflectedMethod;

        public void* GetSuperclass;
        public void* IsAssignableFrom;

        public void* ToReflectedField;

        public void* Throw;
        public void* ThrowNew;
        public void* ExceptionOccurred;
        public void* ExceptionDescribe;
        public void* ExceptionClear;
        public void* FatalError;

        public void* PushLocalFrame;
        public void* PopLocalFrame;

        public void* NewGlobalRef;
        public void* DeleteGlobalRef;
        public void* DeleteLocalRef;
        public void* IsSameObject;
        public void* NewLocalRef;
        public void* EnsureLocalCapacity;

        public void* AllocObject;
        public void* NewObject;
        public void* NewObjectV;
        public void* NewObjectA;

        public void* GetObjectClass;
        public void* IsInstanceOf;

        public void* GetMethodID;

        public void* CallObjectMethod;
        public void* CallObjectMethodV;
        public void* CallObjectMethodA;

        public void* CallBooleanMethod;
        public void* CallBooleanMethodV;
        public void* CallBooleanMethodA;

        public void* CallByteMethod;
        public void* CallByteMethodV;
        public void* CallByteMethodA;

        public void* CallCharMethod;
        public void* CallCharMethodV;
        public void* CallCharMethodA;

        public void* CallShortMethod;
        public void* CallShortMethodV;
        public void* CallShortMethodA;

        public void* CallIntMethod;
        public void* CallIntMethodV;
        public void* CallIntMethodA;

        public void* CallLongMethod;
        public void* CallLongMethodV;
        public void* CallLongMethodA;

        public void* CallFloatMethod;
        public void* CallFloatMethodV;
        public void* CallFloatMethodA;

        public void* CallDoubleMethod;
        public void* CallDoubleMethodV;
        public void* CallDoubleMethodA;

        public void* CallVoidMethod;
        public void* CallVoidMethodV;
        public void* CallVoidMethodA;

        public void* CallNonvirtualObjectMethod;
        public void* CallNonvirtualObjectMethodV;
        public void* CallNonvirtualObjectMethodA;

        public void* CallNonvirtualBooleanMethod;
        public void* CallNonvirtualBooleanMethodV;
        public void* CallNonvirtualBooleanMethodA;

        public void* CallNonvirtualByteMethod;
        public void* CallNonvirtualByteMethodV;
        public void* CallNonvirtualByteMethodA;

        public void* CallNonvirtualCharMethod;
        public void* CallNonvirtualCharMethodV;
        public void* CallNonvirtualCharMethodA;

        public void* CallNonvirtualShortMethod;
        public void* CallNonvirtualShortMethodV;
        public void* CallNonvirtualShortMethodA;

        public void* CallNonvirtualIntMethod;
        public void* CallNonvirtualIntMethodV;
        public void* CallNonvirtualIntMethodA;

        public void* CallNonvirtualLongMethod;
        public void* CallNonvirtualLongMethodV;
        public void* CallNonvirtualLongMethodA;

        public void* CallNonvirtualFloatMethod;
        public void* CallNonvirtualFloatMethodV;
        public void* CallNonvirtualFloatMethodA;

        public void* CallNonvirtualDoubleMethod;
        public void* CallNonvirtualDoubleMethodV;
        public void* CallNonvirtualDoubleMethodA;

        public void* CallNonvirtualVoidMethod;
        public void* CallNonvirtualVoidMethodV;
        public void* CallNonvirtualVoidMethodA;

        public void* GetFieldID;

        public void* GetObjectField;
        public void* GetBooleanField;
        public void* GetByteField;
        public void* GetCharField;
        public void* GetShortField;
        public void* GetIntField;
        public void* GetLongField;
        public void* GetFloatField;
        public void* GetDoubleField;

        public void* SetObjectField;
        public void* SetBooleanField;
        public void* SetByteField;
        public void* SetCharField;
        public void* SetShortField;
        public void* SetIntField;
        public void* SetLongField;
        public void* SetFloatField;
        public void* SetDoubleField;

        public void* GetStaticMethodID;

        public void* CallStaticObjectMethod;
        public void* CallStaticObjectMethodV;
        public void* CallStaticObjectMethodA;

        public void* CallStaticBooleanMethod;
        public void* CallStaticBooleanMethodV;
        public void* CallStaticBooleanMethodA;

        public void* CallStaticByteMethod;
        public void* CallStaticByteMethodV;
        public void* CallStaticByteMethodA;

        public void* CallStaticCharMethod;
        public void* CallStaticCharMethodV;
        public void* CallStaticCharMethodA;

        public void* CallStaticShortMethod;
        public void* CallStaticShortMethodV;
        public void* CallStaticShortMethodA;

        public void* CallStaticIntMethod;
        public void* CallStaticIntMethodV;
        public void* CallStaticIntMethodA;

        public void* CallStaticLongMethod;
        public void* CallStaticLongMethodV;
        public void* CallStaticLongMethodA;

        public void* CallStaticFloatMethod;
        public void* CallStaticFloatMethodV;
        public void* CallStaticFloatMethodA;

        public void* CallStaticDoubleMethod;
        public void* CallStaticDoubleMethodV;
        public void* CallStaticDoubleMethodA;

        public void* CallStaticVoidMethod;
        public void* CallStaticVoidMethodV;
        public void* CallStaticVoidMethodA;

        public void* GetStaticFieldID;
        public void* GetStaticObjectField;
        public void* GetStaticBooleanField;
        public void* GetStaticByteField;
        public void* GetStaticCharField;
        public void* GetStaticShortField;
        public void* GetStaticIntField;
        public void* GetStaticLongField;
        public void* GetStaticFloatField;
        public void* GetStaticDoubleField;

        public void* SetStaticObjectField;
        public void* SetStaticBooleanField;
        public void* SetStaticByteField;
        public void* SetStaticCharField;
        public void* SetStaticShortField;
        public void* SetStaticIntField;
        public void* SetStaticLongField;
        public void* SetStaticFloatField;
        public void* SetStaticDoubleField;

        public void* NewString;
        public void* GetStringLength;
        public void* GetStringChars;
        public void* ReleaseStringChars;

        public void* NewStringUTF;
        public void* GetStringUTFLength;
        public void* GetStringUTFChars;
        public void* ReleaseStringUTFChars;

        public void* GetArrayLength;

        public void* NewObjectArray;
        public void* GetObjectArrayElement;
        public void* SetObjectArrayElement;

        public void* NewBooleanArray;
        public void* NewByteArray;
        public void* NewCharArray;
        public void* NewShortArray;
        public void* NewIntArray;
        public void* NewLongArray;
        public void* NewFloatArray;
        public void* NewDoubleArray;

        public void* GetBooleanArrayElements;
        public void* GetByteArrayElements;
        public void* GetCharArrayElements;
        public void* GetShortArrayElements;
        public void* GetIntArrayElements;
        public void* GetLongArrayElements;
        public void* GetFloatArrayElements;
        public void* GetDoubleArrayElements;

        public void* ReleaseBooleanArrayElements;
        public void* ReleaseByteArrayElements;
        public void* ReleaseCharArrayElements;
        public void* ReleaseShortArrayElements;
        public void* ReleaseIntArrayElements;
        public void* ReleaseLongArrayElements;
        public void* ReleaseFloatArrayElements;
        public void* ReleaseDoubleArrayElements;

        public void* GetBooleanArrayRegion;
        public void* GetByteArrayRegion;
        public void* GetCharArrayRegion;
        public void* GetShortArrayRegion;
        public void* GetIntArrayRegion;
        public void* GetLongArrayRegion;
        public void* GetFloatArrayRegion;
        public void* GetDoubleArrayRegion;

        public void* SetBooleanArrayRegion;
        public void* SetByteArrayRegion;
        public void* SetCharArrayRegion;
        public void* SetShortArrayRegion;
        public void* SetIntArrayRegion;
        public void* SetLongArrayRegion;
        public void* SetFloatArrayRegion;
        public void* SetDoubleArrayRegion;

        public void* RegisterNatives;
        public void* UnregisterNatives;

        public void* MonitorEnter;
        public void* MonitorExit;

        public void* GetJavaVM;

        public void* GetStringRegion;
        public void* GetStringUTFRegion;

        public void* GetPrimitiveArrayCritical;
        public void* ReleasePrimitiveArrayCritical;

        public void* GetStringCritical;
        public void* ReleaseStringCritical;

        public void* NewWeakGlobalRef;
        public void* DeleteWeakGlobalRef;

        public void* ExceptionCheck;

        public void* NewDirectByteBuffer;
        public void* GetDirectBufferAddress;
        public void* GetDirectBufferCapacity;

        public void* GetObjectRefType;

#endif


    }

}