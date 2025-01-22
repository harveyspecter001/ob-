using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x0200027F RID: 639
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterPresetCurrentStateRequest : IMessage<CharacterPresetCurrentStateRequest>, IMessage, IEquatable<CharacterPresetCurrentStateRequest>, IDeepCloneable<CharacterPresetCurrentStateRequest>, IBufferMessage
	{
		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x001B363C File Offset: 0x001B183C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterPresetCurrentStateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x001B364C File Offset: 0x001B184C
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

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x001B365C File Offset: 0x001B185C
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

		// Token: 0x06001DD7 RID: 7639 RVA: 0x001B366C File Offset: 0x001B186C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetCurrentStateRequest()
		{
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x001B367C File Offset: 0x001B187C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetCurrentStateRequest(CharacterPresetCurrentStateRequest other)
		{
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x001B368C File Offset: 0x001B188C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetCurrentStateRequest Clone()
		{
			return null;
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x001B369C File Offset: 0x001B189C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x001B36AC File Offset: 0x001B18AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterPresetCurrentStateRequest other)
		{
			return true;
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x001B36BC File Offset: 0x001B18BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x001B36CC File Offset: 0x001B18CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x001B36DC File Offset: 0x001B18DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x001B36EC File Offset: 0x001B18EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x001B36FC File Offset: 0x001B18FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x001B370C File Offset: 0x001B190C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterPresetCurrentStateRequest other)
		{
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x001B371C File Offset: 0x001B191C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x001B372C File Offset: 0x001B192C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x001B373C File Offset: 0x001B193C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterPresetCurrentStateRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					CharacterPresetCurrentStateRequest._parser = new MessageParser<CharacterPresetCurrentStateRequest>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x001B3820 File Offset: 0x001B1A20
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CwMMCFO5FAWpfp8vBbhF()
		{
			return true;
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x001B3828 File Offset: 0x001B1A28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterPresetCurrentStateRequest ToyjiXO5zlyP4hsmse86()
		{
			return null;
		}

		// Token: 0x04000A90 RID: 2704
		private static readonly MessageParser<CharacterPresetCurrentStateRequest> _parser;

		// Token: 0x04000A91 RID: 2705
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A92 RID: 2706
		internal static CharacterPresetCurrentStateRequest iGydDmO5q6l5L71EuFGm;
	}
}
