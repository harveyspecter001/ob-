using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Area
{
	// Token: 0x02000C5A RID: 3162
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SubareaRewardRateEvent : IMessage<SubareaRewardRateEvent>, IMessage, IEquatable<SubareaRewardRateEvent>, IDeepCloneable<SubareaRewardRateEvent>, IBufferMessage
	{
		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x060097E0 RID: 38880 RVA: 0x00278E28 File Offset: 0x00277028
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<SubareaRewardRateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x060097E1 RID: 38881 RVA: 0x00278E38 File Offset: 0x00277038
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x060097E2 RID: 38882 RVA: 0x00278E48 File Offset: 0x00277048
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060097E3 RID: 38883 RVA: 0x00278E58 File Offset: 0x00277058
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubareaRewardRateEvent()
		{
		}

		// Token: 0x060097E4 RID: 38884 RVA: 0x00278E68 File Offset: 0x00277068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubareaRewardRateEvent(SubareaRewardRateEvent other)
		{
		}

		// Token: 0x060097E5 RID: 38885 RVA: 0x00278E78 File Offset: 0x00277078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubareaRewardRateEvent Clone()
		{
			return null;
		}

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x060097E6 RID: 38886 RVA: 0x00278E88 File Offset: 0x00277088
		// (set) Token: 0x060097E7 RID: 38887 RVA: 0x00278E98 File Offset: 0x00277098
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SubareaRate
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

		// Token: 0x060097E8 RID: 38888 RVA: 0x00278EA8 File Offset: 0x002770A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060097E9 RID: 38889 RVA: 0x00278EB8 File Offset: 0x002770B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SubareaRewardRateEvent other)
		{
			return true;
		}

		// Token: 0x060097EA RID: 38890 RVA: 0x00278EC8 File Offset: 0x002770C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060097EB RID: 38891 RVA: 0x00278ED8 File Offset: 0x002770D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060097EC RID: 38892 RVA: 0x00278EE8 File Offset: 0x002770E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060097ED RID: 38893 RVA: 0x00278EF8 File Offset: 0x002770F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060097EE RID: 38894 RVA: 0x00278F08 File Offset: 0x00277108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060097EF RID: 38895 RVA: 0x00278F18 File Offset: 0x00277118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SubareaRewardRateEvent other)
		{
		}

		// Token: 0x060097F0 RID: 38896 RVA: 0x00278F28 File Offset: 0x00277128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060097F1 RID: 38897 RVA: 0x00278F38 File Offset: 0x00277138
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060097F2 RID: 38898 RVA: 0x00278F48 File Offset: 0x00277148
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SubareaRewardRateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					SubareaRewardRateEvent._parser = new MessageParser<SubareaRewardRateEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060097F3 RID: 38899 RVA: 0x00279040 File Offset: 0x00277240
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dJg8X9JN2XDgGFYg3xsZ()
		{
			return true;
		}

		// Token: 0x060097F4 RID: 38900 RVA: 0x00279048 File Offset: 0x00277248
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SubareaRewardRateEvent g1b3rNJNEZYfr31atiCl()
		{
			return null;
		}

		// Token: 0x04003864 RID: 14436
		private static readonly MessageParser<SubareaRewardRateEvent> _parser;

		// Token: 0x04003865 RID: 14437
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003866 RID: 14438
		public const int SubareaRateFieldNumber = 1;

		// Token: 0x04003867 RID: 14439
		private int subareaRate_;

		// Token: 0x04003868 RID: 14440
		private static SubareaRewardRateEvent aaGllkJN9AfUhXG7LQZQ;
	}
}
