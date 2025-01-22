using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Chat
{
	// Token: 0x020008D2 RID: 2258
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChatPrivateCopyMessageEvent : IMessage<ChatPrivateCopyMessageEvent>, IMessage, IEquatable<ChatPrivateCopyMessageEvent>, IDeepCloneable<ChatPrivateCopyMessageEvent>, IBufferMessage
	{
		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x06006DA8 RID: 28072 RVA: 0x0023585C File Offset: 0x00233A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChatPrivateCopyMessageEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x06006DA9 RID: 28073 RVA: 0x0023586C File Offset: 0x00233A6C
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

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x06006DAA RID: 28074 RVA: 0x0023587C File Offset: 0x00233A7C
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

		// Token: 0x06006DAB RID: 28075 RVA: 0x0023588C File Offset: 0x00233A8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatPrivateCopyMessageEvent()
		{
		}

		// Token: 0x06006DAC RID: 28076 RVA: 0x0023589C File Offset: 0x00233A9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatPrivateCopyMessageEvent(ChatPrivateCopyMessageEvent other)
		{
		}

		// Token: 0x06006DAD RID: 28077 RVA: 0x002358AC File Offset: 0x00233AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatPrivateCopyMessageEvent Clone()
		{
			return null;
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x06006DAE RID: 28078 RVA: 0x002358BC File Offset: 0x00233ABC
		// (set) Token: 0x06006DAF RID: 28079 RVA: 0x002358CC File Offset: 0x00233ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Content
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x06006DB0 RID: 28080 RVA: 0x002358DC File Offset: 0x00233ADC
		// (set) Token: 0x06006DB1 RID: 28081 RVA: 0x002358EC File Offset: 0x00233AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Date
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x06006DB2 RID: 28082 RVA: 0x002358FC File Offset: 0x00233AFC
		// (set) Token: 0x06006DB3 RID: 28083 RVA: 0x0023590C File Offset: 0x00233B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetCharacterId
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

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x06006DB4 RID: 28084 RVA: 0x0023591C File Offset: 0x00233B1C
		// (set) Token: 0x06006DB5 RID: 28085 RVA: 0x0023592C File Offset: 0x00233B2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string TargetName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x06006DB6 RID: 28086 RVA: 0x0023593C File Offset: 0x00233B3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ObjectItemInventory> Object
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006DB7 RID: 28087 RVA: 0x0023594C File Offset: 0x00233B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006DB8 RID: 28088 RVA: 0x0023595C File Offset: 0x00233B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChatPrivateCopyMessageEvent other)
		{
			return true;
		}

		// Token: 0x06006DB9 RID: 28089 RVA: 0x0023596C File Offset: 0x00233B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006DBA RID: 28090 RVA: 0x0023597C File Offset: 0x00233B7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006DBB RID: 28091 RVA: 0x0023598C File Offset: 0x00233B8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006DBC RID: 28092 RVA: 0x0023599C File Offset: 0x00233B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006DBD RID: 28093 RVA: 0x002359AC File Offset: 0x00233BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006DBE RID: 28094 RVA: 0x002359BC File Offset: 0x00233BBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChatPrivateCopyMessageEvent other)
		{
		}

		// Token: 0x06006DBF RID: 28095 RVA: 0x002359CC File Offset: 0x00233BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006DC0 RID: 28096 RVA: 0x002359DC File Offset: 0x00233BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006DC1 RID: 28097 RVA: 0x002359EC File Offset: 0x00233BEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChatPrivateCopyMessageEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					ChatPrivateCopyMessageEvent._parser = new MessageParser<ChatPrivateCopyMessageEvent>(() => null);
					num2 = 3;
					continue;
				case 3:
					ChatPrivateCopyMessageEvent._repeated_object_codec = FieldCodec.ForMessage<ObjectItemInventory>(42U, MA8hA9n80ObjtPbmhEGb.XVInXhlssT(MA8hA9n80ObjtPbmhEGb.D4hn8C6OFiy));
					num2 = 4;
					continue;
				case 4:
					return;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
				{
					num2 = 5;
				}
			}
		}

		// Token: 0x06006DC2 RID: 28098 RVA: 0x00235AF4 File Offset: 0x00233CF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bR0jTTJAQ7QsZqA2vNY7()
		{
			return true;
		}

		// Token: 0x06006DC3 RID: 28099 RVA: 0x00235AFC File Offset: 0x00233CFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChatPrivateCopyMessageEvent pHDCEmJA746cRA6BQ7V2()
		{
			return null;
		}

		// Token: 0x04002652 RID: 9810
		private static readonly MessageParser<ChatPrivateCopyMessageEvent> _parser;

		// Token: 0x04002653 RID: 9811
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002654 RID: 9812
		public const int ContentFieldNumber = 1;

		// Token: 0x04002655 RID: 9813
		private string content_;

		// Token: 0x04002656 RID: 9814
		public const int DateFieldNumber = 2;

		// Token: 0x04002657 RID: 9815
		private string date_;

		// Token: 0x04002658 RID: 9816
		public const int TargetCharacterIdFieldNumber = 3;

		// Token: 0x04002659 RID: 9817
		private long targetCharacterId_;

		// Token: 0x0400265A RID: 9818
		public const int TargetNameFieldNumber = 4;

		// Token: 0x0400265B RID: 9819
		private string targetName_;

		// Token: 0x0400265C RID: 9820
		public const int ObjectFieldNumber = 5;

		// Token: 0x0400265D RID: 9821
		private static readonly FieldCodec<ObjectItemInventory> _repeated_object_codec;

		// Token: 0x0400265E RID: 9822
		private readonly RepeatedField<ObjectItemInventory> object_;

		// Token: 0x0400265F RID: 9823
		internal static ChatPrivateCopyMessageEvent UjAgkfJAwvi5cPbd1CGw;
	}
}
