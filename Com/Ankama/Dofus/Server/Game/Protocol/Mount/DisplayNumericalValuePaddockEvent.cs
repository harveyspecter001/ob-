using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x02000392 RID: 914
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DisplayNumericalValuePaddockEvent : IMessage<DisplayNumericalValuePaddockEvent>, IMessage, IEquatable<DisplayNumericalValuePaddockEvent>, IDeepCloneable<DisplayNumericalValuePaddockEvent>, IBufferMessage
	{
		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06002ACD RID: 10957 RVA: 0x001C950C File Offset: 0x001C770C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<DisplayNumericalValuePaddockEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06002ACE RID: 10958 RVA: 0x001C951C File Offset: 0x001C771C
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

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06002ACF RID: 10959 RVA: 0x001C952C File Offset: 0x001C772C
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

		// Token: 0x06002AD0 RID: 10960 RVA: 0x001C953C File Offset: 0x001C773C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayNumericalValuePaddockEvent()
		{
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x001C954C File Offset: 0x001C774C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayNumericalValuePaddockEvent(DisplayNumericalValuePaddockEvent other)
		{
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x001C955C File Offset: 0x001C775C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisplayNumericalValuePaddockEvent Clone()
		{
			return null;
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x001C956C File Offset: 0x001C776C
		// (set) Token: 0x06002AD4 RID: 10964 RVA: 0x001C957C File Offset: 0x001C777C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MountId
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

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x001C958C File Offset: 0x001C778C
		// (set) Token: 0x06002AD6 RID: 10966 RVA: 0x001C959C File Offset: 0x001C779C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Value
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

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06002AD7 RID: 10967 RVA: 0x001C95AC File Offset: 0x001C77AC
		// (set) Token: 0x06002AD8 RID: 10968 RVA: 0x001C95C0 File Offset: 0x001C77C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MountCharacteristic Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (MountCharacteristic)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x001C95D0 File Offset: 0x001C77D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x001C95E0 File Offset: 0x001C77E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(DisplayNumericalValuePaddockEvent other)
		{
			return true;
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x001C95F0 File Offset: 0x001C77F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x001C9600 File Offset: 0x001C7800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x001C9610 File Offset: 0x001C7810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x001C9620 File Offset: 0x001C7820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x001C9630 File Offset: 0x001C7830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x001C9640 File Offset: 0x001C7840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(DisplayNumericalValuePaddockEvent other)
		{
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x001C9650 File Offset: 0x001C7850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x001C9660 File Offset: 0x001C7860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x001C9670 File Offset: 0x001C7870
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DisplayNumericalValuePaddockEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_72;
					case 3:
						return;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
				}
				IL_72:
				DisplayNumericalValuePaddockEvent._parser = new MessageParser<DisplayNumericalValuePaddockEvent>(() => null);
				num = 3;
			}
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x001C9740 File Offset: 0x001C7940
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ygRt6vOrQ6W1my3BJMZi()
		{
			return true;
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x001C9748 File Offset: 0x001C7948
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DisplayNumericalValuePaddockEvent EdlRvsOr7CwTFUDQQkeI()
		{
			return null;
		}

		// Token: 0x04000F19 RID: 3865
		private static readonly MessageParser<DisplayNumericalValuePaddockEvent> _parser;

		// Token: 0x04000F1A RID: 3866
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F1B RID: 3867
		public const int MountIdFieldNumber = 1;

		// Token: 0x04000F1C RID: 3868
		private int mountId_;

		// Token: 0x04000F1D RID: 3869
		public const int ValueFieldNumber = 2;

		// Token: 0x04000F1E RID: 3870
		private int value_;

		// Token: 0x04000F1F RID: 3871
		public const int TypeFieldNumber = 3;

		// Token: 0x04000F20 RID: 3872
		private MountCharacteristic type_;

		// Token: 0x04000F21 RID: 3873
		private static DisplayNumericalValuePaddockEvent XiGitmOrwSN0DCnhB5B5;
	}
}
