using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x0200035D RID: 861
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountSterilizeRequest : IMessage<MountSterilizeRequest>, IMessage, IEquatable<MountSterilizeRequest>, IDeepCloneable<MountSterilizeRequest>, IBufferMessage
	{
		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06002868 RID: 10344 RVA: 0x001C672C File Offset: 0x001C492C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MountSterilizeRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06002869 RID: 10345 RVA: 0x001C673C File Offset: 0x001C493C
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

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x0600286A RID: 10346 RVA: 0x001C674C File Offset: 0x001C494C
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

		// Token: 0x0600286B RID: 10347 RVA: 0x001C675C File Offset: 0x001C495C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountSterilizeRequest()
		{
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x001C676C File Offset: 0x001C496C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountSterilizeRequest(MountSterilizeRequest other)
		{
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x001C677C File Offset: 0x001C497C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountSterilizeRequest Clone()
		{
			return null;
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x001C678C File Offset: 0x001C498C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x001C679C File Offset: 0x001C499C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountSterilizeRequest other)
		{
			return true;
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x001C67AC File Offset: 0x001C49AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x001C67BC File Offset: 0x001C49BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x001C67CC File Offset: 0x001C49CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x001C67DC File Offset: 0x001C49DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x001C67EC File Offset: 0x001C49EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x001C67FC File Offset: 0x001C49FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountSterilizeRequest other)
		{
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x001C680C File Offset: 0x001C4A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x001C681C File Offset: 0x001C4A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x001C682C File Offset: 0x001C4A2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountSterilizeRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						MountSterilizeRequest._parser = new MessageParser<MountSterilizeRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						continue;
					case 4:
						goto IL_83;
					}
					return;
				}
				IL_83:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
			}
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x001C68FC File Offset: 0x001C4AFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NCiJZgOhCbUQ2KX6lAnf()
		{
			return true;
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x001C6904 File Offset: 0x001C4B04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountSterilizeRequest saOUPiOhDe19JP7x9bLH()
		{
			return null;
		}

		// Token: 0x04000E5D RID: 3677
		private static readonly MessageParser<MountSterilizeRequest> _parser;

		// Token: 0x04000E5E RID: 3678
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E5F RID: 3679
		private static MountSterilizeRequest HAVsEsOh0lpIWEjodK3v;
	}
}
