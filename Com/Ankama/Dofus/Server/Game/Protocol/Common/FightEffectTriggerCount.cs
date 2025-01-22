using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000AD5 RID: 2773
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightEffectTriggerCount : IMessage<FightEffectTriggerCount>, IMessage, IEquatable<FightEffectTriggerCount>, IDeepCloneable<FightEffectTriggerCount>, IBufferMessage
	{
		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x06008485 RID: 33925 RVA: 0x0026464C File Offset: 0x0026284C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightEffectTriggerCount> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x06008486 RID: 33926 RVA: 0x0026465C File Offset: 0x0026285C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x06008487 RID: 33927 RVA: 0x0026466C File Offset: 0x0026286C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06008488 RID: 33928 RVA: 0x0026467C File Offset: 0x0026287C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightEffectTriggerCount()
		{
		}

		// Token: 0x06008489 RID: 33929 RVA: 0x0026468C File Offset: 0x0026288C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightEffectTriggerCount(FightEffectTriggerCount other)
		{
		}

		// Token: 0x0600848A RID: 33930 RVA: 0x0026469C File Offset: 0x0026289C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightEffectTriggerCount Clone()
		{
			return null;
		}

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x0600848B RID: 33931 RVA: 0x002646AC File Offset: 0x002628AC
		// (set) Token: 0x0600848C RID: 33932 RVA: 0x002646BC File Offset: 0x002628BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EffectId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x0600848D RID: 33933 RVA: 0x002646CC File Offset: 0x002628CC
		// (set) Token: 0x0600848E RID: 33934 RVA: 0x002646DC File Offset: 0x002628DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long TargetId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x0600848F RID: 33935 RVA: 0x002646EC File Offset: 0x002628EC
		// (set) Token: 0x06008490 RID: 33936 RVA: 0x002646FC File Offset: 0x002628FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06008491 RID: 33937 RVA: 0x0026470C File Offset: 0x0026290C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008492 RID: 33938 RVA: 0x0026471C File Offset: 0x0026291C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightEffectTriggerCount other)
		{
			return true;
		}

		// Token: 0x06008493 RID: 33939 RVA: 0x0026472C File Offset: 0x0026292C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008494 RID: 33940 RVA: 0x0026473C File Offset: 0x0026293C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008495 RID: 33941 RVA: 0x0026474C File Offset: 0x0026294C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008496 RID: 33942 RVA: 0x0026475C File Offset: 0x0026295C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008497 RID: 33943 RVA: 0x0026476C File Offset: 0x0026296C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008498 RID: 33944 RVA: 0x0026477C File Offset: 0x0026297C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightEffectTriggerCount other)
		{
		}

		// Token: 0x06008499 RID: 33945 RVA: 0x0026478C File Offset: 0x0026298C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600849A RID: 33946 RVA: 0x0026479C File Offset: 0x0026299C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600849B RID: 33947 RVA: 0x002647AC File Offset: 0x002629AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightEffectTriggerCount()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					FightEffectTriggerCount._parser = new MessageParser<FightEffectTriggerCount>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x0600849C RID: 33948 RVA: 0x00264890 File Offset: 0x00262A90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ddmMZZJsVt2hC4WL42YR()
		{
			return true;
		}

		// Token: 0x0600849D RID: 33949 RVA: 0x00264898 File Offset: 0x00262A98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightEffectTriggerCount xNKf0kJs0RSn8nwK7ZWQ()
		{
			return null;
		}

		// Token: 0x04003078 RID: 12408
		private static readonly MessageParser<FightEffectTriggerCount> _parser;

		// Token: 0x04003079 RID: 12409
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400307A RID: 12410
		public const int EffectIdFieldNumber = 1;

		// Token: 0x0400307B RID: 12411
		private int effectId_;

		// Token: 0x0400307C RID: 12412
		public const int TargetIdFieldNumber = 2;

		// Token: 0x0400307D RID: 12413
		private long targetId_;

		// Token: 0x0400307E RID: 12414
		public const int CountFieldNumber = 3;

		// Token: 0x0400307F RID: 12415
		private int count_;

		// Token: 0x04003080 RID: 12416
		internal static FightEffectTriggerCount EdOQp9JsrsfKe2gUSEmW;
	}
}
