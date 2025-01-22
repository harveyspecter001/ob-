using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x0200091D RID: 2333
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterForceSelectionReadyRequest : IMessage<CharacterForceSelectionReadyRequest>, IMessage, IEquatable<CharacterForceSelectionReadyRequest>, IDeepCloneable<CharacterForceSelectionReadyRequest>, IBufferMessage
	{
		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x06007134 RID: 28980 RVA: 0x0023C3B8 File Offset: 0x0023A5B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterForceSelectionReadyRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x06007135 RID: 28981 RVA: 0x0023C3C8 File Offset: 0x0023A5C8
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

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x06007136 RID: 28982 RVA: 0x0023C3D8 File Offset: 0x0023A5D8
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

		// Token: 0x06007137 RID: 28983 RVA: 0x0023C3E8 File Offset: 0x0023A5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterForceSelectionReadyRequest()
		{
		}

		// Token: 0x06007138 RID: 28984 RVA: 0x0023C3F8 File Offset: 0x0023A5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterForceSelectionReadyRequest(CharacterForceSelectionReadyRequest other)
		{
		}

		// Token: 0x06007139 RID: 28985 RVA: 0x0023C408 File Offset: 0x0023A608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterForceSelectionReadyRequest Clone()
		{
			return null;
		}

		// Token: 0x0600713A RID: 28986 RVA: 0x0023C418 File Offset: 0x0023A618
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600713B RID: 28987 RVA: 0x0023C428 File Offset: 0x0023A628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterForceSelectionReadyRequest other)
		{
			return true;
		}

		// Token: 0x0600713C RID: 28988 RVA: 0x0023C438 File Offset: 0x0023A638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600713D RID: 28989 RVA: 0x0023C448 File Offset: 0x0023A648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600713E RID: 28990 RVA: 0x0023C458 File Offset: 0x0023A658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600713F RID: 28991 RVA: 0x0023C468 File Offset: 0x0023A668
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007140 RID: 28992 RVA: 0x0023C478 File Offset: 0x0023A678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007141 RID: 28993 RVA: 0x0023C488 File Offset: 0x0023A688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterForceSelectionReadyRequest other)
		{
		}

		// Token: 0x06007142 RID: 28994 RVA: 0x0023C498 File Offset: 0x0023A698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007143 RID: 28995 RVA: 0x0023C4A8 File Offset: 0x0023A6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007144 RID: 28996 RVA: 0x0023C4B8 File Offset: 0x0023A6B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterForceSelectionReadyRequest()
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
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				CharacterForceSelectionReadyRequest._parser = new MessageParser<CharacterForceSelectionReadyRequest>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06007145 RID: 28997 RVA: 0x0023C584 File Offset: 0x0023A784
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CF7iomJecM8ylauMfUEf()
		{
			return true;
		}

		// Token: 0x06007146 RID: 28998 RVA: 0x0023C58C File Offset: 0x0023A78C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterForceSelectionReadyRequest e7oJr8JeU6hTPYgaQTOk()
		{
			return null;
		}

		// Token: 0x040027A5 RID: 10149
		private static readonly MessageParser<CharacterForceSelectionReadyRequest> _parser;

		// Token: 0x040027A6 RID: 10150
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027A7 RID: 10151
		private static CharacterForceSelectionReadyRequest ugX2OmJelHI998d9p8Xm;
	}
}
